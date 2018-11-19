using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;
using System.IO;

namespace Wildsoft.About
{
    public class SceneChangedEventArgs : EventArgs
    {
        public Color BackColor { get; set; }
        public int SceneNumber { get; set; }
    }
        
    public class AboutDrawer
    {
        public delegate void OnSceneChanged(object sender, SceneChangedEventArgs e);
        public event OnSceneChanged SceneChanged;

        private struct AboutScene
        {
            public int PauseTimeout;
            public int StringsHeight;
            public int StringsCount;
            public Color BackColor;
            public int DrawTimeout;
        }

        private struct AboutString
        {
            public string Text;
            public string FontName;
            public Color TextColor;
            public int SceneNumber;
        }
   
        public PictureBox pctDraw = null;
        private Timer tmrDraw = null;
        private Timer tmrPause = null;
        private Dictionary<string, Font> DrawFonts = new Dictionary<string, Font>();
        private List<AboutScene> Scenes = new List<AboutScene>();
        private List<AboutString> Strings = new List<AboutString>();

        Bitmap view = null;
        Graphics graph;

        private string DrawScript = string.Empty;

        private int SceneNumber = 0; //Номер "сцены"        
        AboutScene tmpScene; // переменная для сбора данных "сцены"

        private bool ScriptLoaded = false;
                
        private int starty = 0;
        private int endy = 0;
        private int teky = 0;
        private int centery = 0;
        private Color back_color;        

        public int SpaceHeight { get; set; } //высота пустого места между строк
        public int DefaultDrawTimeout { get; set; } //таймаут для рисования (меньше - быстрее)
        public Color DefaultBackColor { get; set; } //цвета по умолчанию
        public Color DefaultTextColor { get; set; }
        public string ErrorMessage { get; private set; }        

        public AboutDrawer(PictureBox pb)
        {
            tmrDraw = new Timer();
            tmrPause = new Timer();
            tmrDraw.Tick += new EventHandler(tmrDraw_Tick);
            tmrPause.Tick += new EventHandler(tmrPause_Tick);

            pctDraw = pb;
            
            view = new Bitmap(pctDraw.Width, pctDraw.Height);
            graph = Graphics.FromImage((Image)view);
            pctDraw.Image = (Image)view;

            DrawFonts.Clear();
            Font Default = new Font("Microsoft Sans Serif", 8, FontStyle.Regular, GraphicsUnit.Point);
            DrawFonts.Add("default", Default);
            Scenes.Clear();

            SpaceHeight = 3; //значение по умолчанию для пустого места между строк
            DefaultDrawTimeout = 10; //... для скорости обновления таймера рисования
            
            //цвета по умолчанию
            DefaultBackColor = Color.Gray;
            DefaultTextColor = Color.White;
            
            ScriptLoaded = false;
        }

        public bool StartDraw()
        {
            if (!ScriptLoaded)
            {
                ErrorMessage = "Script not loaded.";
                return false;
            }

            starty = teky = pctDraw.Height;
            endy = pctDraw.Location.Y;
            centery = starty / 2;

            if (Scenes.Count < 1)
            {
                ErrorMessage = "No scenes.";
                return false;
            }

            if (Scenes[0].DrawTimeout <= 0)
            {
                tmrDraw.Interval = DefaultDrawTimeout;
            }
            else
            {
                tmrDraw.Interval = Scenes[0].DrawTimeout;
            }

            back_color = Scenes[0].BackColor;
            SceneNumber = 0;
            if (SceneChanged != null)
            {
                SceneChangedEventArgs evarg = new SceneChangedEventArgs();
                evarg.BackColor = back_color;
                evarg.SceneNumber = SceneNumber;
                SceneChanged(this, evarg);
            }


            tmrDraw.Start();

            return true;
        }

        public bool LoadFromFile(string Filename)
        {
            string drawscript = "";

            try
            {
                drawscript = File.ReadAllText(Filename);
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                return false;
            }

            return LoadScript(drawscript);
        }

        //тест на правильность скрипта
        //загрузка скрипта и данных
        public bool LoadScript(string drawscript)
        {
            ScriptLoaded = false;
            //обнуляем счетчики для номера сцены и создаем новую
            SceneNumber = 0;
            tmpScene = new AboutScene();
            tmpScene.BackColor = DefaultBackColor; //параметры по умолчанию для 1 сцены
            tmpScene.DrawTimeout = DefaultDrawTimeout;
            tmpScene.PauseTimeout = 0;

            //проверяем, есть ли скрипт вообще
            if (string.IsNullOrEmpty(drawscript))
            {
                ErrorMessage = "No data";
                return false;
            }            
            string[] buf = drawscript.Split('\n');
            if (buf.Length < 2)
            {
                ErrorMessage = "No data";
                return false;
            }

            int num = 0;
            foreach (string s in buf)
            {
                num++;
                string Command = s.Trim(); //убираем граничные пробелы
                int comment = Command.IndexOf("~");
                if (comment != -1) //убираем комментарии (c тильды)
                {
                    Command = Command.Substring(0, comment);
                }
                Command = Command.Trim(); //убираем граничные пробелы
                //и последнюю точку с запятой, если она есть
                if (Command.EndsWith(";")) Command = Command.Substring(0, 
                    Command.Length - 1);
                
                Command = Command.Trim(); //опять убираем пробелы
                if (Command == string.Empty) continue; //пропускаем пустые строки                                
                
                //разбиваем команду на составляющие части
                string[] cmdbuf = Command.Split(';');
                cmdbuf[0] = cmdbuf[0].Trim();
                cmdbuf[0] = cmdbuf[0].ToLowerInvariant();

                switch (cmdbuf[0])
                {
                    case "addfont":
                        {
                            if (!AddFont(cmdbuf))
                            {
                                ErrorMessage = ErrorMessage + " in string " + num.ToString();
                                return false;
                            }
                        }; break;
                    case "addstring":
                        {
                            if (!AddString(cmdbuf))
                            {
                                ErrorMessage = ErrorMessage + " in string " + num.ToString();
                                return false;
                            }
                        }; break;
                    case "scene":
                        {
                            if (!AddScene(cmdbuf))
                            {
                                ErrorMessage = ErrorMessage + " in string " + num.ToString();
                                return false;
                            }

                        }; break;
                    default:
                        {
                            ErrorMessage = "Unknow command in string " + num;
                            return false;
                        };
                }
            }

            AddScene(new string[] {"scene"}); //добавляем последнюю сцену
            ScriptLoaded = true;
            return true;
        }

        private bool AddString(string[] Command)
        {
            string about_string = "";
            string font_name = "";
            Color text_color = DefaultTextColor;

            if (Command.Length < 2)
            {
                ErrorMessage = "Wrong 'addstring' command";
                return false;
            }

            about_string = Command[1];

            if (Command.Length >= 3) //есть шрифт текста
            {
                Font tmpFnt = GetFont(Command[2]);
                if (tmpFnt == null)
                {
                    ErrorMessage = "Unknow font name";
                    return false;
                }
                else
                {
                    font_name = Command[2].Trim();
                }
            }
            else //шрифт не задан, будет по умолчанию
            {
                font_name = "default";
            }

            if (Command.Length >= 4) //задан цвет текста
            {
                if (!FromRGBAString(Command[3], ref text_color))
                {                    
                    return false;
                }
            }

            AboutString tmpString = new AboutString();
            tmpString.FontName = font_name;
            tmpString.SceneNumber = SceneNumber;
            tmpString.Text = about_string;
            tmpString.TextColor = text_color;

            Strings.Add(tmpString);
            Font fnt = GetFont(font_name);
            int height = graph.MeasureString(tmpString.Text, fnt).ToSize().Height;
            tmpScene.StringsHeight += SpaceHeight + height;
            tmpScene.StringsCount++;
            
            Font f = GetFont(font_name);            

            return true;
        }
        
        private Font GetFont(string FontName)
        {
            //выдает шрифт из набора загруженных шрифтов по его имени            
            if (!DrawFonts.ContainsKey(FontName)) return null;

            return DrawFonts[FontName];
        }

        private bool AddScene(string[] Command)
        {
            //добавляет "сцены"
            bool prevadd = false;
            if (tmpScene.StringsCount != 0) //если в сцене есть строки
            {
                //tmpScene.StringsHeight = tmpScene.StringsCount * SpaceHeight;
                //добавляем предыдущую сцену в список
                Scenes.Add(tmpScene);
                prevadd = true;
            }

            //разбираем команду и создаем следующую сцену
            int pause_timeout = 0;
            int draw_timeout = 0;
            Color back_color = DefaultBackColor;            
            
            // интервал таймера прорисовки для сцены (меньше - быстрее)
            if (Command.Length >= 2)
            {
                Command[1] = Command[1].Trim();
                if (!string.IsNullOrEmpty(Command[1]))
                {
                    try
                    {
                        draw_timeout = Convert.ToInt32(Command[1]);
                    }
                    catch
                    {
                        ErrorMessage = "Wrong Draw Timeout (ms)";
                        return false;
                    }
                }
            }

            //пауза в центре "экрана" (ms)
            if (Command.Length >= 3)
            {
                Command[2] = Command[2].Trim();
                if (!string.IsNullOrEmpty(Command[2]))
                {
                    try
                    {
                        pause_timeout = Convert.ToInt32(Command[2]);
                    }
                    catch
                    {
                        ErrorMessage = "Wrong Pause Timeout (ms)";
                        return false;
                    }
                }
            }
            
            //цвет фона
            if (Command.Length >= 4)
            {
                if (!FromRGBAString(Command[3], ref back_color))
                {
                    return false;
                }
            }
            
            //создаем следующую сцену
            tmpScene = new AboutScene();            
            tmpScene.PauseTimeout = pause_timeout; //устанавливаем параметры
            tmpScene.DrawTimeout = draw_timeout;
            tmpScene.BackColor = back_color;

            if (prevadd) //предыдущая сцена была добавлена
            {
                SceneNumber++; //инкреминируем номер для следующей сцены
            }

            return true;
        }

        private FontStyle FontStyleFromString(string Style)
        {            
            FontStyle Ret = FontStyle.Regular;            
            
            Style = Style.Trim(); //удаляем граничные
            Style = RemoveDupSpaces(Style); //и лишние внутренние пробелы
            if (string.IsNullOrEmpty(Style)) //если строка пуста - стиль Regular
            {                
                return Ret;
            }
            
            string[] stylebuf = Style.Split(' ');
            
            for (int i = 0; i < stylebuf.Length; i++) 
            {
                //пропускаем пустые строки
                if (string.IsNullOrEmpty(stylebuf[i])) continue;

                //преобразуем название стилей к формату 
                //"первая буква заглавная, остальные строчные"
                stylebuf[i] = stylebuf[i].ToLowerInvariant(); //в нижний регистр
                string first = stylebuf[i][0].ToString(); //вытаскиваем 1-й символ
                first = first.ToUpperInvariant(); //в верхний регистр его
                stylebuf[i] = stylebuf[i].Remove(0, 1); //удаляем 1-й символ
                stylebuf[i] = first + stylebuf[i]; //на место его - символ в верхнем регистре

                //парсим стиль
                //(исключение перехватывает вызывающая ф-ция)
                FontStyle tmpFS = FontStyle.Regular;
                tmpFS = (FontStyle)Enum.Parse(typeof(FontStyle), stylebuf[i]);

                if (i == 0) //это первый эл-т массива с названиями стилей
                {
                    Ret = tmpFS; //присваиваем выходному стилю распарсенный
                }
                else //надо добавить остальные стили
                {
                    Ret = Ret | tmpFS;
                }
            }


            return Ret;
        }

        private bool AddFont(string[] Command)
        {
            //формат - addfont;FontFamily;размер pt;FontStyle;
            //Имя для последующего использования

            if (Command.Length < 5)
            {
                ErrorMessage = "Wrong addfont command";
                return false;
            }
            string FamilyName = Command[1].Trim();
            float FontSize = 0;

            try
            {
                FontSize = ConvertToFloat(Command[2].Trim());
            }
            catch
            {
                ErrorMessage = "Wrong Font Size (use '.')";
                return false;
            }

            FontStyle Style = FontStyle.Regular;

            try
            {
                Style = FontStyleFromString(Command[3].Trim());
            }
            catch (Exception ex)
            {
                ErrorMessage = "Wrong Font Style ["+ex.Message+"]";
                return false;
            }

            string Name = Command[4].Trim();
            if (string.IsNullOrEmpty(Name))
            {
                ErrorMessage = "Empty Name";
                return false;
            }

            Font tmpfnt = new Font(FamilyName, FontSize, Style, GraphicsUnit.Point);
            if (DrawFonts.ContainsKey(Name))
            {
                DrawFonts[Name] = tmpfnt;
            }
            else
            {
                DrawFonts.Add(Name, tmpfnt);
            }

            return true;
        }       
        
        void tmrPause_Tick(object sender, EventArgs e)
        {
            tmrPause.Stop();
            tmrDraw.Start();
        }        

        void tmrDraw_Tick(object sender, EventArgs e)
        {
            graph.Clear(back_color);
            int sidx = GetStartIndex(SceneNumber);
            /*if (sidx == -1) //в сцене нет строк
            {
                //пускаем следующую
                NextScene();
            }*/
            int nexty = teky;

            //рисуем все строчки сцены
            for (int i = 0; i < Scenes[SceneNumber].StringsCount; i++)
            {                
                Font fnt = GetFont(Strings[i+sidx].FontName);
                int pixlen = graph.MeasureString(Strings[i+sidx].Text, fnt).ToSize().Width;
                int height = graph.MeasureString(Strings[i + sidx].Text, fnt).ToSize().Height;
                int x = (pctDraw.Width - pixlen) / 2;
                Brush brush = new SolidBrush(Strings[i+sidx].TextColor);                

                graph.DrawString(Strings[i+sidx].Text, fnt, brush, x, nexty);
                nexty = nexty + SpaceHeight + height;

                //Font test = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point);
                //graph.DrawString(teky.ToString(), test, Brushes.Red, 0, 0);
            }

            if (Scenes[SceneNumber].PauseTimeout > 0) //если нужна пауза
            {
                if (teky + Scenes[SceneNumber].StringsHeight/2 == centery)
                {
                    tmrPause.Interval = Scenes[SceneNumber].PauseTimeout;
                    tmrDraw.Stop();
                    tmrPause.Start();
                }
            }

            if (teky <= Scenes[SceneNumber].StringsHeight*(-1)) //конец сцены
            {
                NextScene();
            }

            pctDraw.Image = (Image)view;
            teky--;
        }

        private void NextScene()
        {
            //запускаем следующую сцену
            SceneNumber++;
            if (SceneNumber >= Scenes.Count) SceneNumber = 0;

            if (Scenes[SceneNumber].DrawTimeout <= 0)
            {
                tmrDraw.Interval = DefaultDrawTimeout;
            }
            else
            {
                tmrDraw.Interval = Scenes[SceneNumber].DrawTimeout;
            }

            back_color = Scenes[SceneNumber].BackColor;

            teky = starty;

            if (SceneChanged != null)
            {
                SceneChangedEventArgs evarg = new SceneChangedEventArgs();
                evarg.BackColor = back_color;
                evarg.SceneNumber = SceneNumber;
                SceneChanged(this, evarg);
            }
        }

        private int GetStartIndex(int SceneN)
        {
            int i = 0;
            foreach (AboutString abS in Strings)
            {
                if (abS.SceneNumber == SceneN) return i;
                i++;
            }
            return -1;
        }

        private float ConvertToFloat(string Number)
        {
            NumberFormatInfo format = new NumberFormatInfo();
            format.NumberDecimalSeparator = ".";
            return (float)Convert.ToDouble(Number, format);
        }

        private string RemoveDupSpaces(string s)
        {
            while (s.Contains("  "))
            {
                s = s.Replace("  ", "");
            }

            return s;
        }

        private bool FromRGBAString(string RGBAs, ref Color Col)
        {
            byte  A = 0; byte R = 0; byte G = 0; byte B = 0;
            
            RGBAs = RGBAs.Trim();
            RGBAs = RemoveDupSpaces(RGBAs); //удаляем дублирующиеся пробелы

            string[] splitbuf = RGBAs.Split(' ');

            if (splitbuf.Length < 3) //не все задано
            {
                ErrorMessage = "Wrong color string";
                return false;
            }

            //вытаскиваем значения RGB
            try
            {
                R = Convert.ToByte(splitbuf[0], 16);
                G = Convert.ToByte(splitbuf[1], 16);
                B = Convert.ToByte(splitbuf[2], 16);
            }
            catch (Exception ex)
            {
                ErrorMessage = "Wrong color string (RGB) [" + ex.Message + "]";
                return false;
            }

            if (splitbuf.Length < 4) //не задана альфа, ставим в 255
            {
                A = 255;                
            }
            else
            {
                //вытаскиваем альфу
                try
                {
                    A = Convert.ToByte(splitbuf[3], 16);
                }
                catch (Exception ex)
                {
                    ErrorMessage = "Wrong color string (Alpha) ["+ex.Message+"]";
                    return false;
                }
            }

            Col = Color.FromArgb(A, R, G, B);
            return true;
        }
    }
}

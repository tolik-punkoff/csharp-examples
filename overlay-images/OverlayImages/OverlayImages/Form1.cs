using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace OverlayImages
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
            //Настраиваем размер PictureBox для отображения результата
            pbResult.Size = pbFlag.Size;

            //Берем целевое изображение
            Bitmap TargetBitmap = Properties.Resources.flag;
            
            //Берем накладываемое изображение
            Bitmap OverlayBitmap = Properties.Resources.trizub_small;

            //Создаем результирующее изображение (пока пустое)
            Bitmap ResultBitmap = new Bitmap(TargetBitmap.Width, TargetBitmap.Height,
                PixelFormat.Format32bppArgb);

            //Создаем объект Graphics из результирующего изображения
            Graphics graph = Graphics.FromImage(ResultBitmap);
            
            //настраиваем метод совмещения изображений
            graph.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;

            //рисуем основное изображение
            graph.DrawImage(TargetBitmap, 0, 0);

            //рисуем накладываемое изображение
            graph.DrawImage(OverlayBitmap, (TargetBitmap.Width-OverlayBitmap.Width)/2, 
                (TargetBitmap.Height-OverlayBitmap.Height)/2,
                OverlayBitmap.Width,OverlayBitmap.Height);

            //для иллюстрации выводим оригинальные изображения
            pbFlag.Image = TargetBitmap;
            pbTrizub.Image = OverlayBitmap;

            //выводим результат
            pbResult.Image = ResultBitmap;

            //Изменение размеров

            //задаем новые размеры
            int NewWidth = ResultBitmap.Width / 2;
            int NewHeight = ResultBitmap.Height / 2;

            //Настраиваем PictureBox для вывода уменьшенного изображения
            pbResize.Size = new Size(NewWidth, NewHeight);
            
            //создаем новый Bitmap для измененного изображения
            Bitmap ResizeBitmap = new Bitmap(NewWidth, 
                NewHeight);
            
            //создаем объект Graphics, который будет изменять размер
            Graphics ResizeGraph = Graphics.FromImage(ResizeBitmap);
            //ставим высокое качество
            ResizeGraph.InterpolationMode = 
                System.Drawing.Drawing2D.InterpolationMode.High;
            //рисуем изображение с измененным размером
            ResizeGraph.DrawImage(ResultBitmap, 0, 0, NewWidth, NewHeight);

            //отображаем результат
            pbResize.Image = ResizeBitmap;
        }
    }
}

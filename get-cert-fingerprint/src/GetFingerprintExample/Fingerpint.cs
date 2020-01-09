using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace GetFingerprintExample
{
    public static class Fingerpint
    {
        public static string GetCertFingerprint(string CertFile, string AlgName)
        {
            if (!File.Exists(CertFile))
            {
                Console.WriteLine("File not found.");
                return null;
            }

            //load certificate
            X509Certificate2 X509 = null;
            try
            {
                X509 = new X509Certificate2(CertFile);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            byte[] cert = X509.GetRawCertData();
            
            //create hash algorithm
            HashAlgorithm alg = null;
            switch (AlgName.ToUpperInvariant())
            {
                case "MD5": alg = MD5.Create(); break;
                case "SHA1": alg = SHA1.Create(); break;
                case "SHA256": alg = SHA256.Create(); break;
                case "SHA384": alg = SHA384.Create(); break;
                case "SHA512": alg = SHA512.Create(); break;
                default:
                    {
                        Console.WriteLine("Unknow algorithm.");
                        return null;
                    }
            }
            
            //calculate hash and return value
            byte[] hash = alg.ComputeHash(cert);
            string hex = BitConverter.ToString(hash).ToLowerInvariant().
                Replace("-", "");

            return hex;
        }
    }
}

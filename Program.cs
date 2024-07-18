using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BtkAkademiVeriYapilariTemel
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            //Hashtable Örnek Proje 
            Console.WriteLine("Başlığı Giriniz : ");
            string baslik = Console.ReadLine();

            //küçültme
            baslik = baslik.ToLower();
            //BTK Akademi'den Yeni Eğitim Aldım
            //Hashtable
            var karakterSeti = new Hashtable()
            {
                {'ü','u'},
                {'ı','i'},
                {'ğ','g'},
                {' ','-'},
                {'\'','-'},
                {'ş','s'},
                {'ö','o'},
                {'ç','c'},
                {'.','-'},
                {'?','-'}
            };

            foreach(DictionaryEntry item in karakterSeti)
            {
                baslik = baslik.Replace((char)item.Key, (char)item.Value);
            }

            Console.WriteLine(baslik);

            Console.ReadKey();
        }
    }
}

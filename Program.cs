using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BtkAkademiVeriYapilariTemel
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            var sehirKodlari = new Dictionary<int, string>()
            {
                {312, "Ankara"},
                {212, "İstanbul"},
                {412, "Malatya"}
            };

            //Add
            sehirKodlari.Add(322, "Osmaniye");
            sehirKodlari.Add(755, "Hakkari");

            //Access
            Console.WriteLine("Erişme : " + sehirKodlari[212]);

            //ContainsKey

            if (!sehirKodlari.ContainsKey(622))
            {
                Console.WriteLine("\aKayseri'nin kodu sözlükte bulunmuyor.");
                sehirKodlari.Add(622, "Kayseri");
                Console.WriteLine("Yeni Kod Kaydedildi!");
            }

            //ContainsValue

            if (!sehirKodlari.ContainsValue("Aydın"))
            {
                Console.WriteLine("\aAydın'ın kodu sözlükte bulunmuyor.");
                sehirKodlari.Add(144, "Aydın");
                Console.WriteLine("Yeni Kod Kaydedildi!");
            }

            var kodlar = sehirKodlari;
            foreach(var k in kodlar)
            {
                Console.WriteLine(k);
            }


            Console.ReadKey();
            
        }
    }
}
using System;
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
            OgretimElemani ogr_el1 = new OgretimElemani(100, "Samet", "Altıtaş", true);
            Console.WriteLine($"Öğretim Elemanı 1 :\n{ogr_el1}");

            OgretimElemani ogr_el2 = ogr_el1;
            Console.WriteLine($"Öğretim Elemanı 2 :\n{ogr_el2}");
            ogr_el2.Degerleri_Sil();
            Console.WriteLine("Öğretim Elemanı 2 sıfırlandı.");
            Console.WriteLine($"Öğretim Elemanı 1 :\n{ogr_el1}");
            Console.WriteLine($"Öğretim Elemanı 2 :\n{ogr_el2}");

            //Sadece Öğretim Elemanı 2'yi sıfırlamış olmama rağmen Öğretim Elemanı 1'in de bilgileri sıfırlandı.
            //Bu da Class datatype'ların Adres yani Referans Tipli olduğunu gösterir.

            Console.ReadKey();
        }
    }
}

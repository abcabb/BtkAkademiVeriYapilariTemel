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
            List<Ogrenci> ogrenciListesi = new List<Ogrenci>()
            {
                new Ogrenci(220403825, "Semi", "Şen", true),
                new Ogrenci(220403465, "Ali", "Demir", true),
                new Ogrenci(220403754, "Yağmur", "Çelik", false),
                new Ogrenci(220403147, "Ayşe", "Kırmızı", false)
            };

            foreach (Ogrenci o in ogrenciListesi)
            {
                Console.WriteLine(o.ToString());
            }   

            Console.ReadKey();
        }
    }
}

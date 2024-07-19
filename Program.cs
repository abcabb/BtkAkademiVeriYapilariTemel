using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
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
            var kitapIcerigi = new SortedList()
            {
                {1, "Giriş"},
                {25, "Değişkenler"},
                {40, "Operatörler"},
                {50, "Döngüler"},
                {80, "Fonksiyonlar"}
            };
            Console.WriteLine("KİTAP İÇERİĞİ\n" + new string('-',50));
            Console.WriteLine($"{"Konu Başlığı", -20}{"Sayfa Sayısı", -5}");
            foreach(DictionaryEntry listeElemanı in kitapIcerigi)
            {
                Console.WriteLine($"{listeElemanı.Value, -20}{listeElemanı.Key,-5}");
            }

            Console.ReadKey();
        }
    }
}

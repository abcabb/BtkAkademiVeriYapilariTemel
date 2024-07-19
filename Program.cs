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
            //Sorted List

            var liste = new SortedList()
            {
                {1, "Bir"},
                {2, "İki"},
                {7, "Yedi"},
                {3, "Üç"},
                {6, "Altı"},
                {9, "Dokuz"},
            };
            
            liste.Add(4, "Dört");

            foreach(DictionaryEntry item in liste)
            {
                Console.WriteLine("{0} :       {1}", item.Key, item.Value);
            }
            //Elemanların Sıralanmış olarak listeye eklendiğini görüyoruz.

            Console.WriteLine("Listedeki eleman sayısı :    {0}",liste.Count);
            Console.WriteLine("Listenin kapasitesi :       {0}", liste.Capacity);
            liste.TrimToSize();
            Console.WriteLine("Listenin kapasitesi :     {0}", liste.Capacity);

            //Key ile Value değerine erişme
            Console.WriteLine(liste[3]);

            //Index ile Value değerine erişme
            Console.WriteLine(liste.GetByIndex(0));

            //Index ile Key değerine erişme
            Console.WriteLine(liste.GetKey(0));

            //Liste sonundaki elemanın Value değeri
            Console.WriteLine(liste.GetByIndex(liste.Count-1));

            //Liste sonundaki elemanın anahtarını almak
            Console.WriteLine(liste.GetKey(liste.Count-1));

            //Listenin Anahtarlarını gösterme
            Console.WriteLine("ANAHTARLAR");
            var anahtarlar = liste.Keys;
            foreach(var a in anahtarlar)
            {
                Console.WriteLine(a);
            }

            //Listenin Değerlerini gösterme
            Console.WriteLine("DEĞERLER");
            var degerler = liste.Values;
            foreach(var d in degerler)
            {
                Console.WriteLine(d);
            }

            if (liste.ContainsKey(3))
            {
                liste[3] = "Three";
            }

            foreach(DictionaryEntry i in liste) {  Console.WriteLine(i.Key + " - " + i.Value); }

            Console.ReadKey();
        }
    }
}

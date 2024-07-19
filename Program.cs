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
            var liste = new SortedSet<string>() 
            {
                {"Mehmet"}
            };

            if (liste.Add("Ahmet")) { Console.WriteLine($"{liste.First()} eklendi."); }
            else { Console.WriteLine("\aEkleme başarısız."); }

            Console.WriteLine(liste.Add("Mehmet") == true ? "Mehmet eklendi" : "\aEkleme başarısız.");

            liste.Add("Hamit");
            liste.Add("Şemsi");
            liste.Add("Rümeysa");
            liste.Add("Şevval");

            liste.Remove("Rümeysa");
            liste.RemoveWhere(deger => deger.Contains('i')); //Fonksiyonun içerisindeki ifadede deger diye bir string türünde değişken üretmiş olduk aslında.

            Console.WriteLine("\nİSİM LİSTESİ\n");

            foreach(string l in liste)
            {
                Console.WriteLine(l);
            }

            Console.WriteLine("Set içerisindeki eleman sayısı : {0}", liste.Count);

            Console.ReadKey();
        }
    }
}
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
            var kitapIndex = new SortedDictionary<string, List<int>>()
            {
                {"HTML" ,new List<int>(){ 6, 8, 10} },
                {"JQuery", new List<int>() { 50, 60} },
                {"SQL", new List<int>(){30, 35, 45} },
                {"CSS", new List<int>(){20, 25 } }
            };

            kitapIndex.Add("ASP.NET", new List<int>() { 100, 101, 102 });
            kitapIndex.Add("C#", new List<int>() { 1, 2, 3 });

            //Anahtarları Görme
            Console.WriteLine("ANAHTARLAR :");
            foreach(var k in kitapIndex)
            {
                Console.WriteLine(k.Key);
            }

            //SortedDictionary Instance'larını görme
            Console.WriteLine();
            Console.WriteLine("Anahtarlar Ve Sayfaları :");

            foreach(var k in kitapIndex)
            {
                Console.WriteLine(k.Key);
                foreach(int l in k.Value)
                {
                    Console.WriteLine($"{" > ",10}" + l);
                }
            }

            //SortedDictionary Sayesinde Keyler otomatik olarak sıralandı.

            Console.ReadKey();
        }
    }
}
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
            var sesliHarf = new HashSet<char>() { 'e', 'u', 'ı', 'o', 'ü', 'i', 'ö' };
            sesliHarf.Add('a');

            Console.WriteLine("\nSesli Harfler: ");
            koleksiyonGoster(sesliHarf);

            var liste = new List<char>();
            for (int i = 97; i < 123; i++)
            {
                liste.Add((char)i);
            }

            Console.WriteLine("\nAlfabetik Liste: ");
            koleksiyonGoster(liste);

            /*
            Console.WriteLine("\nTürkçe'de kullanılan sesli harfler: ");
            sesliHarf.ExceptWith(liste);
            koleksiyonGoster(sesliHarf);
            */

            /*
            Console.WriteLine("\nTürkçe Alfabe: ");
            sesliHarf.UnionWith(liste);
            koleksiyonGoster(sesliHarf);
            */

            Console.ReadKey();
        }

        static void koleksiyonGoster(IEnumerable koleksiyon)
        {
            int i=0;
            foreach (char c in koleksiyon)
            {
                Console.Write($"{c,5}");
                i++;
            }
            Console.WriteLine($"\nEleman Sayısı : {i}");

        }
    }
}
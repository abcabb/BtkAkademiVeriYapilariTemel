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
            var list = new List<int>();
            var r = new Random();

            for (int i = 0; i<1000; i++)
            {
                list.Add(r.Next(0, 20));
                Console.Write($"{list[i]}  ");
            }

            var set = new SortedSet<int>(list);

            Console.WriteLine("\n\nUnique(Benzersiz) Elemanlar :\n");

            foreach(int i in set)
            {
                Console.Write("{0} ", i);
            }

            Console.WriteLine($"\n{set.Count} tane benzersiz eleman vardır");

            Console.ReadKey();
        }
    }
}
using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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
            var sesliHarfler = new List<char>()
            {
                {'e'}, {'u'}, {'ı'}, {'o'}, {'ü'}, {'a'}, {'i'}, {'ö'}
            };

            ConsoleKeyInfo secim;
            var queue1 = new Queue<char>();

            foreach (char c in sesliHarfler)
            {
                Console.WriteLine($"{c} kuyruğa eklensin mi? [e/h]");
                secim = Console.ReadKey();
                if (secim.Key == ConsoleKey.E)
                {
                    queue1.Enqueue(c);
                    Console.WriteLine($"\n{c} kuyruğa eklendi.");
                    Console.WriteLine($"Kuyruktaki Eleman Sayısı : {queue1.Count}");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Kuyruktaki elemanları silme işlemi için ESC tuşuna basınız");
            Console.WriteLine();
            secim = Console.ReadKey();

            if (secim.Key == ConsoleKey.Escape)
            {
                while (queue1.Count > 0)
                {
                    Console.WriteLine($"{queue1.Peek()}, Kuyruktan Çıkartılacak.");
                    Console.WriteLine($"{queue1.Dequeue()}, Kuyruktan Çıkartıldı.");
                    Console.WriteLine($"Kuyruktaki Eleman Sayısı : {queue1.Count}");
                }

                Console.ReadKey();
            }
        }
    }
}
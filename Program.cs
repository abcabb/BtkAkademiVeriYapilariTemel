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
            var sehirler = new LinkedList<string>();
            sehirler.AddFirst("Ordu");
            sehirler.AddFirst("Trabzon");
            sehirler.AddLast("Istanbul");
            
            sehirler.AddAfter(sehirler.Find("Ordu"), "Samsun");
            sehirler.AddBefore(sehirler.First.Next.Next, "Giresun");
            sehirler.AddAfter(sehirler.Last.Previous, "Sinop");
            sehirler.AddAfter(sehirler.Find("Sinop"), "Zonguldak");
                       
            foreach(string s in sehirler)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("\nGİDİŞ GÜZERGAHI :\n");

            var gecici = sehirler.First;
            while (gecici != null)
            {
                Console.WriteLine(gecici.Value);
                gecici = gecici.Next;
            }

            Console.WriteLine("\nDÖNÜŞ GÜZERGAHI :\n");

            var gecici2 = sehirler.Last;
            while (gecici2 != null)
            {
                Console.WriteLine(gecici2.Value);
                gecici2 = gecici2.Previous;
            }

            Console.ReadKey();
            
        }
    }
}
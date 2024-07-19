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
            var personelListesi = new Dictionary<int, Personel>()
            {
                {100, new Personel("Enes", "Saygılı", 5500)},
                {101, new Personel("Semi", "Şen", 5400)}
            };    

            foreach(var p in personelListesi)
            {
                Console.WriteLine(p);
            }

            Console.ReadKey();
        }
    }
}
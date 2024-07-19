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
            //Queue Declaration
            var karakterKuyrugu = new Queue<char>();

            //Add, Delete döngülü örnek

            for (int i = 65; i <= 90; i++)
            {
                karakterKuyrugu.Enqueue((char)i);  //Add
            }

            while (karakterKuyrugu.Count > 0)
            {
                Console.WriteLine($"Kuyruğun Başındaki Eleman : {karakterKuyrugu.Peek(),-10}"); // Peek
                Console.WriteLine($"Kuyruktan Çıkarılan Eleman : {karakterKuyrugu.Dequeue(),-10}"); // Delete
            }

            Console.ReadKey();
        }
    }
}

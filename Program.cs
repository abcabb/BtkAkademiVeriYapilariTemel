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
            //SortedSet KÜMELER Uygulaması

            var A = new SortedSet<int>(RastgeleSayiUret(100)); //SortedSet'in Constructor'larından bir tanesi args olarak Collection aldığı için List<int>'i const'a arg olarak girebildik.        
            var B = new SortedSet<int>(RastgeleSayiUret(10));
           
            Console.WriteLine("A Kümesi :");
            foreach(int i in A) Console.Write($"{i} ");

            Console.WriteLine("\nB Kümesi :");
            foreach(int i in B) Console.Write($"{i} ");

            //A.UnionWith(B); // A ve B kümesinin birleşimi
            //A.IntersectWith(B); // A ve B kümesinin kesişimi
            //A.ExceptWith(B); // A'dan B kümesi Çıkarsa 
            A.SymmetricExceptWith(B); // Kesişim dışındaki elemanların birleşimi
            Console.WriteLine("\nA ve B'nin Kesişim Bölgesinde Olmayan Elemanlar :");  //Sorted set Reference Type'lıdır !!!!
            foreach(int i in A) Console.Write($"{i} ");
            Console.WriteLine("\nToplam sayısı : {0}", A.Count);


            Console.ReadKey();
        }

        static List<int> RastgeleSayiUret(int n)
        {
            var list = new List<int>();
            var r = new Random();
            for(int i = 0; i < n; i++)
            {
                list.Add(r.Next(1,1000));
            }

            return list;
        }
    }
}
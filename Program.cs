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
            Console.WriteLine("Lütfen bir sayı giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            var stack1 = new Stack<int>();

            while (sayi > 0)
            {
                stack1.Push(sayi % 10);
                sayi /= 10;
            }

            int i = stack1.Count-1;

            foreach (int x in stack1)
            {
                Console.WriteLine($"{x} x {Math.Pow(10, i)} = {x*Math.Pow(10,i)}");
                i--;
            }
            Console.ReadKey();
        }

        private static void StackOrnegi()
        {
            //Stack Declaration
            var stack1 = new Stack<char>();

            //Add
            stack1.Push('A');
            Console.WriteLine(stack1.Peek());
            stack1.Push('B');
            Console.WriteLine(stack1.Peek());
            stack1.Push('C');
            Console.WriteLine(stack1.Peek());

            //Delete
            Console.WriteLine("Yığından çıkartılan eleman : {0}", stack1.Pop());
            Console.WriteLine("Yığından çıkartılan eleman : {0}", stack1.Pop());
            Console.WriteLine("Yığından çıkartılan eleman : {0}", stack1.Pop());
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BtkAkademiVeriYapilariTemel
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            var karakterStack = new Stack<char>();

            for(int i = 65; i<=90; i++)
            {
                karakterStack.Push((char)i);
                Console.WriteLine($"{karakterStack.Peek()}, Yığına Eklendi.");
                Console.WriteLine("Yığındaki Eleman Sayısı = {0}",karakterStack.Count);
            }
            Console.WriteLine("Press a button to clear the Stack :");
            Console.ReadKey();

            while (karakterStack.Count > 0)
            {
                Console.WriteLine($"{karakterStack.Pop()}, Yığından Çıkarıldı.");
                Console.WriteLine("Yığındaki Eleman Sayısı = {0}", karakterStack.Count);
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

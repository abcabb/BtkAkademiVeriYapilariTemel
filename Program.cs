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


            Console.ReadKey();
        }
    }
}

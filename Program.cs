using System;
using System.Collections;
using System.Collections.Generic;
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
            //Dizilerin farklı yollarla oluşturulması ve gösterimi

            int[] sayilar = new int[] { 1, 2, 3, 4, 5, };
            var numbers = Array.CreateInstance(typeof(int), 5);
            numbers.SetValue(5, 0);
            numbers.SetValue(3, 1);
            numbers.SetValue(8, 2);
            numbers.SetValue(6, 3);
            numbers.SetValue(12, 4);

            var sayilar2 = new ArrayList(sayilar);

            for(int i=0; i<numbers.Length; i++)
            {
                Console.WriteLine($"sayilar[{i}] = {sayilar[i]} - numbers[{i}] = {numbers.GetValue(i)} - sayilar2[{i}] = {sayilar2[i]}");
            }

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtkAkademiVeriYapilariTemel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //8-bit signed integer
            Console.WriteLine(nameof(SByte));
            Console.WriteLine($"Alt limit :  {SByte.MinValue,20}");
            Console.WriteLine($"Üst limit :  {SByte.MaxValue,20}");
            Console.WriteLine($"Boyut :      {sizeof(SByte),20}"); //1 çıktısı 1 byte demektir. 1 byte 8 bit'tir. ve dolayısıyla -128 ve 127 arasında 256 farklı değer alabilir.

            //8-bit unsigned integer
            Console.WriteLine(nameof(Byte));
            Console.WriteLine($"Alt limit :  {Byte.MinValue,20}");
            Console.WriteLine($"Üst limit :  {Byte.MaxValue,20}");
            Console.WriteLine($"Boyut :      {sizeof(Byte),20}"); //Byte, 8 bitlik unsigned bir integer'ı temsil eder.  

            //16-bit signed integer
            Console.WriteLine(nameof(Int16));
            Console.WriteLine($"Alt limit :  {Int16.MinValue,20}");
            Console.WriteLine($"Üst limit :  {Int16.MaxValue,20}");
            Console.WriteLine($"Boyut :      {sizeof(Int16),20}"); //Byte, 8 bitlik unsigned bir integer'ı temsil eder.  

            //16-bit unsigned integer
            Console.WriteLine(nameof(UInt16));
            Console.WriteLine($"Alt limit :  {UInt16.MinValue,20}");
            Console.WriteLine($"Üst limit :  {UInt16.MaxValue,20}");
            Console.WriteLine($"Boyut :      {sizeof(UInt16),20}"); //Byte, 8 bitlik unsigned bir integer'ı temsil eder.  

            //32-bit signed integer
            Console.WriteLine(nameof(Int32));
            Console.WriteLine($"Alt limit :  {Int32.MinValue,20}");
            Console.WriteLine($"Üst limit :  {Int32.MaxValue,20}");
            Console.WriteLine($"Boyut :      {sizeof(Int32),20}"); //Byte, 8 bitlik unsigned bir integer'ı temsil eder.  

            //Double
            Console.WriteLine(nameof(Double));
            Console.WriteLine($"Alt limit :  {Double.MinValue,20}");
            Console.WriteLine($"Üst limit :  {Double.MaxValue,20}");
            Console.WriteLine($"Boyut :      {sizeof(Double),20}"); //Byte, 8 bitlik unsigned bir integer'ı temsil eder.  

            Console.ReadKey();
        }
    }
}

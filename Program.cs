using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BtkAkademiVeriYapilariTemel
{
    internal partial class Program
    {
        public struct Nokta
        {
            private int x { get; set; }
            private int y {  get; set; }

            public Nokta(int x, int y)
            {
                this.x = x; 
                this.y = y;
            }

            public override string ToString()
            {
                return $"{this.x},{this.y}";
            }

            public void setOrigin()
            {
                this.x = 0;
                this.y = 0;
            }

            public void degistir()
            {
                int gecici = x;
                x = y;
                y = gecici;
            }
        }

        static void Main(string[] args)
        {
            //struct' ların Değer Tipli Çalıştığının Gösterimi

            Nokta n1 = new Nokta(3,4);
            Console.WriteLine($"n1:       {n1}");
            n1.degistir();
            Console.WriteLine($"n1:       {n1}");

            Nokta n2 = n1;
            Console.WriteLine($"n2:       {n2}");
            n2.degistir();
            Console.WriteLine($"n2:       {n2}");
            Console.WriteLine($"n1:       {n1}");

            Console.ReadKey();
        }
    }
}

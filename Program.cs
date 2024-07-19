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
        public class Sehir : IComparable<Sehir>
        {
            private int plakaNo { get; set; }
            private string sehirAdi { get; set; }

            public Sehir(int plakaNo, string sehirAdi) { this.plakaNo = plakaNo; this.sehirAdi = sehirAdi; }

            public override string ToString()
            {
                return $"{this.plakaNo,-5} - {this.sehirAdi}";
            }

            int IComparable<Sehir>.CompareTo(Sehir other)
            {
                if (this.plakaNo < other.plakaNo) { return -1 ; }
                else if(this.plakaNo == other.plakaNo){ return 0; }
                else{ return 1; }
            }
        }

        static void Main(string[] args)
        {
            var sayilar = new List<int>() {6 ,15, 3, 68, 45, 23, 17 };
            sayilar.Sort();       // Integer karşılaştırabiliyor çünkü integer içerisinde IComparable Interface'i bulunuyor. Hatta Generic(IComparable<int>) olanı bile var.
            sayilar.ForEach(s => Console.WriteLine(s));

            var listOfSehir = new List<Sehir>()
            {
                new Sehir(06, "Ankara"),
                new Sehir(34, "İstanbul"),
                new Sehir(35, "İzmir"),
                new Sehir(17, "Çanakkale"),
                new Sehir(44, "Malatya")
            };
            listOfSehir.Add(new Sehir(01, "Adana"));
            listOfSehir.Sort();     //lisOfSehir Listesinin de Sıralanması için IComparable tarzı bir arayüz içermesi lazım. Dolayısıyla Sehir Class'ına Interface Implemente edelim.
            listOfSehir.ForEach(los => Console.WriteLine(los));

            Console.ReadKey();
        }
    }
}

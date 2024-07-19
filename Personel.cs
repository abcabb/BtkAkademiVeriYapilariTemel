namespace BtkAkademiVeriYapilariTemel
{
    internal partial class Program
    {
        public class Personel
        {
            private int sicilNo;
            private string isim;
            private string soyisim;
            private decimal maas;

            public Personel(string isim, string soyisim, decimal maas)
            {                
                this.isim = isim;
                this.soyisim = soyisim;
                this.maas = maas;
            }

            public override string ToString()
            {
                return $"{this.isim,-5} - {this.soyisim,-5} - {this.maas,-5}";
            }
        }
    }
}
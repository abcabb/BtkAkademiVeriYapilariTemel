namespace BtkAkademiVeriYapilariTemel
{
    internal partial class Program
    {
        public class OgretimElemani
        {
            private int og_no { get; set; }
            private string og_isim { get; set; }
            private string og_soyisim { get; set; }
            private bool og_cinsiyet { get; set; }

            public OgretimElemani(int og_no, string og_isim, string og_soyisim, bool og_cinsiyet)
            {
                this.og_no = og_no;
                this.og_isim = og_isim;
                this.og_soyisim = og_soyisim;
                this.og_cinsiyet = og_cinsiyet;
            }

            public override string ToString()
            {
                return $"İsim : {this.og_isim,-10}" +
                    $"Soyisim : {this.og_soyisim,-10}" +
                    $"Numara : {this.og_no,-10}" +
                    string.Format("{0,5}", this.og_cinsiyet == true ? "Bay" : "Bayan");
            }

            public void Degerleri_Sil() 
            {
                this.og_no = 0;
                this.og_isim = null;
                this.og_soyisim = null;
            }
        }
    }
}

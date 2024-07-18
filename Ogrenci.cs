namespace BtkAkademiVeriYapilariTemel
{
    internal partial class Program
    {
        public struct Ogrenci
        {
            private int ogr_no { get; set; }
            private string ogr_isim { get; set; }
            private string ogr_soyisim { get; set; }
            private bool ogr_cinsiyet { get; set; }

            public Ogrenci(int ogr_no, string ogr_isim, string ogr_soyisim, bool ogr_cinsiyet)
            {
                this.ogr_no = ogr_no;
                this.ogr_isim = ogr_isim;
                this.ogr_soyisim = ogr_soyisim;
                this.ogr_cinsiyet = ogr_cinsiyet;
            }

            public override string ToString()
            {
                return $"İsim : {this.ogr_isim},20" +
                    $"Soyisim : {this.ogr_soyisim}" +
                    $"Cinsiyet : {this.ogr_cinsiyet}" +
                    $"Numara : {this.ogr_no}";
            }

        }
    }
}

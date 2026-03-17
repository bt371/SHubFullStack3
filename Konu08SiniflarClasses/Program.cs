namespace Konu08SiniflarClasses
{
    internal class Ev // sınıf tanımlama
    {
        internal string sokakAdi;
        internal int kapiNo;
    }
    /*
        Erişim belirteçleri 4 ana sınıfa ayrılır
        public:erişim kısıtı yoktur, her yerden erişilebilir
        protected: ait olduğu sınıftan ve o sınıftan üretilen sınıflardan erişilebilir
        internal:etkin projeye ait sınıflardan erişilebiliri onların dışında erişilemez
        private:yalnız bulunduğu sınıftan erişilebilir, dıştaki sınıflardan erişilemez
     */ 
    public class deneme
    {
        public string UrunAdi = "public öğeye herkes ulaşabilir";
        protected class test
        {
            string UrunAdi;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu08SiniflarClasses");
            #region Örnek1
            Ev ilkEv = new Ev(); // soyut bir yapı olan ev sınıfından somut bir nesne oluşturduk.
            ilkEv.sokakAdi = "Pınar sk.";
            ilkEv.kapiNo = 10;

            Console.WriteLine("ilkEv sokakAdi:" + ilkEv.sokakAdi);
            Console.WriteLine("ilkEv kapiNo:" + ilkEv.kapiNo);

            Console.WriteLine();

            Ev yazlikEv = new ();
            yazlikEv.sokakAdi = "Deniz sk.";
            yazlikEv.kapiNo=18;

            Console.WriteLine("ilkEv sokakAdi:" + yazlikEv.sokakAdi);
            Console.WriteLine("ilkEv kapiNo:" + yazlikEv.kapiNo);

            Console.WriteLine();

            Ev koyEvi = new ()
            {
                kapiNo = 25,
                sokakAdi = "Maho ağa sokak."
            };

            Console.WriteLine("ilkEv sokakAdi:" + koyEvi.sokakAdi);
            Console.WriteLine("ilkEv kapiNo:" + koyEvi.kapiNo);

            Console.WriteLine();

            #endregion
            #region Örnek 2
            Kullanici kullanici = new()
            {
                Adi = "Murat", Soyadi ="Yılmaz", KullaniciAdi="murt", Sifre ="m123", Id=1

            };
            Console.WriteLine("Kullanıcı adınız:");
            var kullaniciAdi = Console.ReadLine();
            Console.WriteLine("Şifreniz:");
            var sifre =Console.ReadLine();
            if(kullaniciAdi == kullanici.KullaniciAdi && sifre == kullanici.Sifre)
            {
                // sisteme giriş yap
                Console.WriteLine($"Hoşgeldin {kullanici.Adi} {kullanici.Soyadi}");
            }
            else
            {
                Console.WriteLine("Giriş Başarısız!");
            }
            #endregion
            #region Örnek 3

            Araba araba = new()
            {
                Id = 1,
                Marka = "Togg",
                KasaTipi = "Suv",
                Model = "T10x",
                Renk = "Kırmızı",
                ModelYili = 2025
            };

            Araba araba2 = new()
            {
                Id = 2,
                Marka = "Togg",
                KasaTipi = "Sedan",
                Model = "T10F",
                Renk = "Beyaz",
                ModelYili = 2023
            };
            #endregion

            #region Örnek 4
            Kategori kategori = new()
            {
                Id = 3,
                KategoriAdi = "Elektronik"
            };
            Kategori kategori2 = new()
            {
                Id = 4,
                KategoriAdi = "Bilgisayar"
            };
            Kategori kategori3 = new()
            {
                Id = 5,
                KategoriAdi = "Telefon"
            };
            Console.WriteLine();
            Console.WriteLine($"Anasayfa Hakkımızda {kategori.KategoriAdi} {kategori2.KategoriAdi} {kategori3.KategoriAdi} İletişim");
            #endregion

        }
    }
    class Kullanici
    {
        internal int Id;
        internal string KullaniciAdi;
        internal string Sifre;
        internal string Email;
        internal string Adi;
        internal string Soyadi;
    }
    class Araba
    {
        internal int Id;
        internal string Marka;
        internal string Model;
        internal string KasaTipi;
        internal string YakitTipi;
        internal string VitesTipi;
        internal string Renk;
        internal int ModelYili;
    }
}

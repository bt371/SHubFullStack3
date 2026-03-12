namespace Konu12Kalitimİnheritance
{
    class Arac
    {
        public string AracTuru;
        public void Kornacal()
        {
            Console.WriteLine("KOrnaya Basıldı!");

        }

        class Otomobil:Arac // iki nokta üst üste araç dediğimizde araç sınıfındaki içerikler otomobil sınıfında kullanılabilir.
        {
            public string Marka {  get; set; }
            public string Model {  get; set; }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Konu12Kalitimİnheritance");
                Arac arac = new Arac();
                arac.AracTuru = "Otomobil";
                arac.Kornacal();    
                Otomobil otomobil = new Otomobil();
                otomobil.AracTuru = "Otomobil"; // bu değişken araç sınıfından geliyor
                otomobil.Kornacal();
                otomobil.Marka = "Togg";
                otomobil.Model = "T10x";
                Console.WriteLine("otomobil.AracTuru:" + otomobil.AracTuru);
            }
        }
    }

}
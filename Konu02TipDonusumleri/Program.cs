namespace Konu02TipDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu 02 Tip Donusumleri!");
            // İmplicit Casting - Otomatik Dönüşüm
            // Explicit Casting - Manuel Dönüşüm
            Console.WriteLine("İmplicit Casting - Otomatik Dönüşüm");
            Console.WriteLine("İmplicit casting de daha küçük boyutlu bir türü daha büyük bir boyut türüne geçirikendönüşüm otomatik olarak yapılır");
            int sayi = 18;
            double kesirlisayi = sayi; // int türündeki değeri double taşıyabilir.
            Console.WriteLine("sayi degeri:");
            Console.WriteLine(sayi);
            Console.WriteLine("kesirliSayi degeri:");
            Console.WriteLine(kesirlisayi);

            Console.WriteLine();
            Console.WriteLine("Explicit Castiing - Manuel Dönüşüm");
            double kesirliSayi2 = 18;
            int tamsayi = (int)kesirliSayi2;
            Console.WriteLine("kesirliSayi2;");
            Console.WriteLine(kesirliSayi2);
            Console.WriteLine("tamsayi");
            Console.WriteLine(tamsayi);
            Console.WriteLine();

            Console.WriteLine("Diğer Tür Dönüştürme Yöntemleri");
            int tamSayi2 = 10;
            double kesirliSayi3 = 5.25;
            bool islemSonuc = true;

            Console.WriteLine("Lütfen Bir Sayı Giriniz:");
            var girilenDeger = Console.ReadLine();
            Console.WriteLine("girilen Degerin veri tiği:");
            Console.WriteLine(girilenDeger.GetType());

            var parsayi = int.Parse(girilenDeger); // int.parse metodu kendisine verilen string degerin tırnaklarını kaldırarak int tipine çevirir
            Console.WriteLine(parsayi + tamsayi);
            Console.WriteLine(double.Parse(girilenDeger) + kesirliSayi3);
            Console.WriteLine(decimal.Parse(girilenDeger) + tamSayi2);
            Console.WriteLine() ;

            Console.WriteLine("convert sınıf metodlarıyla tip dönüştürme");
            Console.WriteLine(tamSayi2.GetType()); // tam sayi nin veri türünü yazdırır
            Console.WriteLine(Convert.ToString(tamSayi2).GetType()); //tam sayi 2yi stringe çevir ve tipini doğrulamak için ekrana yazdır
            Console.WriteLine(Convert.ToDouble(tamSayi2).GetType());
            Console.WriteLine(Convert.ToInt32(kesirliSayi3).GetType());
            Console.WriteLine(Convert.ToString(islemSonuc).GetType());

            Console.WriteLine();

            object nesne = "123456";
            Console.WriteLine("nesne nin veri tipi: " +nesne.GetType());
            nesne = Convert.ToDecimal(nesne); //nesne decimal e çevrildi
            Console.WriteLine("nesne nin veri tipi :" + nesne.GetType());
            Console.WriteLine("nesne nin değeri :" + nesne);















        }
    }
}

namespace Konu10StringSinifi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu10StringSinifi");
            string degisken;
            char karakter ='a';
            string metinlericin = "yanyana  karakterlerden olşuna metin";
            Ornek1();

        }

        static void Ornek1()
        {
            string birMetin = "Ankara başkenttir";
            string birSayi = "123456789";
            System.String birTarih = "21.01.20226";
            string kod = "//5456dfgd\n"; // buradaki \n kodu enter görevi görür ve kendinden sonra gelecek olan metin

            Console.WriteLine(birMetin.GetType());
            Console.WriteLine(birSayi.GetType());
            Console.WriteLine(birTarih.GetType());
            Console.WriteLine(kod);
            string s = "Barış Manço";
            Console.WriteLine(s);
            Console.WriteLine("for döngüsü");
            for (int i = 0; i < s.Length; i++)  // degişkwnin u<zunluğu kadar dön    
            {
                Console.WriteLine(s[i]); //

            }



            
         



        }  

    }
}

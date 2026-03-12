namespace Konu11Enumlar
{
    internal class Program
    {
        // Enumlar numertor olarak geçer nesneleri numaralandırmak için kullanılır
        /*
         * Enumm tipler üzerindekini kısıtlarlar
         * 1-Enum metodunda bloklar kullanılmaz
         * 2-arayüz(ınterface) kullanamazlar
         * 3-enum blokunda property kullanılmaz
         */
        
        enum Aylar :byte
        {
            Ocak =1, Şubat,Mart,Nisan,Mayıs,Haziran,Temmuz,Ağustos,Eylül,Ekim,Kasım,Aralık
        }

        enum SiparisDurumu
        {
            Hazırlanıyor,Hazırlandı,KargoBekleniyor,Kargolandı,İadeEdildi
        }

        enum Meyveler: int
        {
            Elma=3 , Armut=7, Çilek=1
        }
       
        static void Main(string[] args)
        {
            Console.WriteLine("Konu11Enumlar");
            byte a = (byte)Meyveler.Armut;
            byte b = (byte)Meyveler.Elma;
            byte c = (byte)Meyveler.Elma;
            Console.WriteLine($"{Meyveler.Armut}={a},{Meyveler.Elma}={b},{Meyveler.Çilek}={c}");
            Ornek(SiparisDurum:1);

        }
        static void Ornek(int SiparisDurum)
        {
            if (SiparisDurum)   
        }
    }

}

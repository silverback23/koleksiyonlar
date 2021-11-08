using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<T> class     
            //System.Collections.Generic
            // T -> object türündendir

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(12);
            sayiListesi.Add(172);
            sayiListesi.Add(89);

            List<string> RenkListesi = new List<string>();
            RenkListesi.Add("Kırmızı");
            RenkListesi.Add("Mavi");
            RenkListesi.Add("Yeşil");
            //Diziyi listeye çevirme
            string [] hayvanlar = {"kedi","kuş","balık"};
            List<string> hayvanlistesi= new List<string>(hayvanlar);
            

           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Makao
{
    public class Karta
    {
        int idKarty;
        string? figura;
        string? kolor;
        string? wlasciwosc;

    }
    //public class Wlasciwosc
    //{
    //    public Wlasciwosc()
    //    {
    //        void DobierzNext(int x)
    //        {

    //        }
    //        void DobierzPrev(int x)
    //        {

    //        }
    //        void Czekaj(int x)
    //        {

    //        }
    //        void ZmianaKolejka(int x)
    //        {

    //        }
    //        void ZmianaGracz(int x)
    //        {

    //        }
    //        void NaWszystko()
    //        {
    //            //if walet => nie działa

    //        }
    //        void Blokuj()
    //        {

    //        }
    //    }
    //}
    public class As : Karta
    {
        //zarządaj zmiany koloru dla kolejnego gracza

    }
    public class Walet : Karta
    {
        //zacządaj niefunkcujnej karty dla całej kolejki

    }
    public class Krolowa : Karta
    {
        //można położyć na wszystko oprócz Waleta

    }
    public class KrolBitny : Karta
    {
        //Królowie kier i pik
        //pik: kolejny gracz dobiera 5 kart
        //kier: poprzedni gracz dobiera 5 kart

    }
    public class KrolNiebitny : Karta
    {
        //królowie niebitni, blokują działanie innych królów
    }
    public class Dwa : Karta
    {
        //dobierz 2
    }
    public class Trzy : Karta
    {
        //dobierz 3
    }
    public class Cztery : Karta
    {
        //kolejny gracz czeka kolejkę
    }
    public class Niefunkcyjne : Karta
    {
        //karty które nie mają konkretnej funkcji
        //5-10
    }
    public class Talia
    {
        public Talia()
        {
            
        }

    }
    public class TasowanieTalii  
    {
        public TasowanieTalii()
        {
            Stack<int> stos = new Stack<int>();
            
            
            //foreach (int karta in stos) //jeśli nie zadziała, zmienić int na var
            //{
            //    
            //}
        }
    }
}

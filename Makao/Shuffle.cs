using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;


namespace Makao
{
    public class Karta
    {
        protected int IdKarty { get; set; }
        protected string? Figura { get; set; }
        protected string? Kolor { get; set; }
        protected string? Wlasciwosc { get; set; }

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
        public As()
        {
            Figura = "As";
            void PodajKolor(string kolor)
            {
                Kolor = kolor;
            }
        }
        

    }
    public class Walet : Karta
    {
        //zacządaj niefunkcujnej karty dla całej kolejki
        public Walet()
        {
            Figura = "Walet";
            void PodajKolor(string kolor)
            {
                Kolor = kolor;
            }
        }

    }
    public class Krolowa : Karta
    {
        //można położyć na wszystko oprócz Waleta
        public Krolowa()
        {
            Figura = "As";
            void PodajKolor(string kolor)
            {
                Kolor = kolor;
            }
        }

    }
    public class KrolBitny : Karta
    {
        //Królowie kier i pik
        //pik: kolejny gracz dobiera 5 kart
        //kier: poprzedni gracz dobiera 5 kart
        public KrolBitny()
        {
            Figura = "As";
            void PodajKolor(string kolor)
            {
                Kolor = kolor;
            }
        }

    }
    public class KrolNiebitny : Karta
    {
        //królowie niebitni, blokują działanie innych królów
        public KrolNiebitny()
        {
            Figura = "As";
            void PodajKolor(string kolor)
            {
                Kolor = kolor;
            }
        }
    }
    public class Dwa : Karta
    {
        //dobierz 2
        public Dwa()
        {
            Figura = "As";
            void PodajKolor(string kolor)
            {
                Kolor = kolor;
            }
        }
    }
    public class Trzy : Karta
    {
        //dobierz 3
        public Trzy()
        {
            Figura = "As";
            void PodajKolor(string kolor)
            {
                Kolor = kolor;
            }
        }
    }
    public class Cztery : Karta
    {
        //kolejny gracz czeka kolejkę
        public Cztery()
        {
            Figura = "As";
            void PodajKolor(string kolor)
            {
                Kolor = kolor;
            }
        }
    }
    public class Niefunkcyjne : Karta
    {
        public Niefunkcyjne()
        {
            void PodajFigure(string figura)
            {
                Figura = figura;
            }
            void PodajKolor(string kolor)
            {
                Kolor = kolor;
            }
        }
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Makao
{
    //tzrzeba rozpisać funkcje którę
    public class Karta
    {
        protected int IdKarty { get; set; }
        protected string? Figura { get; set; }
        protected string? Kolor { get; set; }
        protected string? Wlasciwosc { get; set; }
        protected bool IsWlasciwosc { get; set; } = true;
        public string? PokazKolor()
        {
            return Kolor;
        }
        public string? PokazFigure()
        {
            return Figura;
        }
    }
    public class As : Karta
    {
        //zarządaj zmiany koloru dla kolejnego gracza
        public As(int id,string? kolor)
        {
            Figura = "As";
            IdKarty = id;
            Kolor = kolor;
        }       
    }
    public class Walet : Karta
    {
        //zacządaj niefunkcujnej karty dla całej kolejki
        public Walet(int id, string? kolor)
        {
            Figura = "Walet";
            IdKarty = id;
            Kolor = kolor;
        }

    }
    public class Krolowa : Karta
    {
        //można położyć na wszystko oprócz Waleta
        public Krolowa(int id, string? kolor)
        {
            Figura = "Królowa";
            IdKarty = id;
            Kolor = kolor;
        }

    }
    public class KrolBitny : Karta
    {
        //Królowie kier i pik
        //pik: kolejny gracz dobiera 5 kart
        //kier: poprzedni gracz dobiera 5 kart
        public KrolBitny(int id, string? kolor)
        {
            Figura = "Król";
            IdKarty = id;
            Kolor = kolor;
        }

    }
    public class KrolNiebitny : Karta
    {
        //królowie niebitni, blokują działanie innych królów
        public KrolNiebitny(int id, string? kolor)
        {
            Figura = "Król";
            IdKarty = id;
            Kolor = kolor;
        }
    }
    public class Dwa : Karta
    {
        //dobierz 2
        public Dwa(int id, string? kolor)
        {
            Figura = "Dwa";
            IdKarty = id;
            Kolor = kolor;
        }
        
    }
    public class Trzy : Karta
    {
        //dobierz 3
        public Trzy(int id, string? kolor)
        {
            Figura = "Trzy";
            IdKarty = id;
            Kolor = kolor;
        }
    }
    public class Cztery : Karta
    {
        //kolejny gracz czeka kolejkę
        public Cztery(int id, string? kolor)
        {
            Figura = "Cztery";
            IdKarty = id;
            Kolor = kolor;
        }
    }
    public class Niefunkcyjne : Karta
    {
        public Niefunkcyjne(int id, string? kolor, string figura)
        {
            IdKarty = id;
            Figura = figura;
            Kolor = kolor;
            IsWlasciwosc = false;
        }
        //karty które nie mają konkretnej funkcji
        //5-10
    }
    public class Talia
    {
        public List<Karta> Karty {  get; private set; }
        public Talia()
        {
            //Asy = new List<As>();
            Karty = new List<Karta>();
            int id = 0;
            for (int i = 0; i < 4; i++)
            {
                string? kolor = null;
                switch (i)
                {
                    case 0:
                        id = i;
                        kolor = "Kier";
                        break;
                    case 1:
                        id = i;
                        kolor = "Trefl";
                        break;
                    case 2:
                        id = i;
                        kolor = "Pik";
                        break;
                    case 3:
                        id = i;
                        kolor = "Karo";
                        break;
                    default:
                        break;
                }
                As nowyAs = new As(id++, kolor);
                Karty.Add(nowyAs);
                Walet nowyWalet = new Walet(id+4, kolor);
                Karty.Add(nowyWalet);
                Krolowa nowaKrolowa = new Krolowa(id + 8, kolor);
                Karty.Add(nowaKrolowa);
                if (i % 2 == 0) {
                    KrolBitny nowyKrol1 = new KrolBitny(id + 12, kolor);
                    Karty.Add(nowyKrol1);
                }
                else { 
                    KrolNiebitny nowyKrol2 = new KrolNiebitny(id + 12, kolor);
                    Karty.Add(nowyKrol2);
                }
                //2 => 16 - 19
                Dwa noweDwa = new Dwa(id + 16, kolor);
                Karty.Add(noweDwa);
                //3 => 20 - 23
                Trzy noweTrzy = new Trzy(id + 20, kolor);
                Karty.Add(noweTrzy);
                //4 => 24 - 27
                Cztery noweCztery= new Cztery(id + 24, kolor);
                Karty.Add(nowaKrolowa);
                //5-10 => 28-51
                for (int j = 0; j < 6; j++)
                {
                    string liczba = "nic tu nie ma";

                    switch(j)
                    {
                        case 0:
                            liczba = "Pięć";
                            break;
                        case 1:
                            liczba = "Sześć";
                            break;
                        case 2:
                            liczba = "Siedem";
                            break;
                        case 3:
                            liczba = "Osiem";
                            break;
                        case 4:
                            liczba = "Dziewięć";
                            break;
                        case 5:
                            liczba = "Dziesięć";
                            break;
                    }
                    Niefunkcyjne liczby = new Niefunkcyjne(28 + j + i * 6, kolor, liczba);
                    Karty.Add(liczby);
                }
            }
        }
    }
    
    public class Stos
    {
        
    }
    public class Tasowanie
    {
        public Stack<int> Stos = new Stack<int>();
        public Tasowanie()
        {
            
            int IloscKart = 52;
            Random random = new Random();
            for (int i = 0; i < IloscKart; i++)
            {
                int wylosowana;
                do
                {
                    wylosowana = random.Next(0, IloscKart);
                } while (Stos.Contains(wylosowana));

                Stos.Push(wylosowana);
            }



        }
        public string? Dobierz()
        {
            Talia talia = new Talia();
            int Id = Stos.Pop();
            string? PelnaNazwa =talia.Karty[Id].PokazFigure() + " " + talia.Karty[Id].PokazKolor()+"\n";
            return PelnaNazwa;
        }
        public int? Ile()
        {
            int Licz = Stos.Count();           
            return Licz;
        }
    }
}

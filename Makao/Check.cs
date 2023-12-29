using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ten plik w dużym stopniu będzie odwoływać się do Shuffle.cs i to właśnie tam znajduje się większość klas i funkcji które są tutaj używane
namespace Makao
{
    public class Sprawdz
    {
        //będzie trzeba jakoś pobrać wartości kart z ręki i karty ze stosu
        Talia Talia = new Talia();

        public Sprawdz()
        {
            Stos Stosik = new Stos();
        }
        public bool SprawdzKarte(int Stos , int Reka)
            {
            bool CzyMozna = false;
            string? StosKolor = Talia.Karty[Stos].PokazKolor();
            string? StosFigura = Talia.Karty[Stos].PokazFigure();
            string? RekaKolor = Talia.Karty[Reka].PokazKolor();
            string? RekaFigura = Talia.Karty[Reka].PokazFigure();
            if(RekaKolor == StosKolor)  CzyMozna = true;
            if(RekaFigura == StosFigura) CzyMozna = true;
            return CzyMozna;
            
            }
        public int[] KtoreKarty(int Stos, int[] Reka)
        {
            int j = 0;
                for (int i = 0; i < Reka.Length; i++)
                {
                    
                    if (SprawdzKarte(Stos, Reka[i]))
                    {
                        j++;
                    }
                }
                int[] Mozna = new int[j];
                j = 0;
                for (int i = 0; i < Reka.Length; i++)
                {
                    
                    if (SprawdzKarte(Stos, Reka[i]))
                    {
                        Mozna[j] = Reka[i];
                    j++;
                    }
                }
                return Mozna;
            
        }
        
    }
    
    public class Tura
    {
        public string? Akcja;
        public bool wygrana = false;
        
        public Tura() 
        { 
            
        }



        //aktualna akcja --- zawiera czas trwania(liczba tur), 
        //Tura składa się z trzech 
    }
    // w klasie akcja będą funkcje kart, wywoływane w klasie tura
    // 
    public class Akcja
    {
        Talia talia = new Talia();
        public string As()
        {
            return "Wybierz kolor!";

  
        }

        public string Walet()
        {
            return "Wybierz figurę!";
        
        
        }

        public string Królowa()
        {
            return "Pomin kolejnego gracza!";

        }

        public string Król()
        {
            return "Wybierz figurę!";

        }

        public string Dwa()
        {
            return "Dobierz dwie karty!";

        }

        public string Trzy()
        {
            return "Dobierz trzy karty!";

        }

        public string Cztery()
        {
            return "Poczekaj jedną turę!";

        }
    }
}
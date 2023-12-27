using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ten plik w dużym stopniu będzie odwoływać się do Shuffle.cs i to właśnie tam znajduje się większość klas i funkcji które są tutaj używane
namespace Makao
{
    class Sprawdz
    {
        //będzie trzeba jakoś pobrać wartości kart z ręki i karty ze stosu

        public Karta ZReki { get; set; }
        public Karta ZeStosu { get; set; }

        public Sprawdz()
        {
            string Kolor = ZReki.PokazFigure();
            switch (Kolor)
            {
                case "As":

                    break;
                case "Walet":

                    break;
                case "Królowa":

                    break;
                case "Król":

                    break;
                case "Dwa":

                    break;
                case "Trzy":

                    break;
                case "Cztery":

                    break;
                default: break;
            }
        }
        public string AktualnyKolor()
        {
            string Kolor = ZeStosu.PokazKolor();
            return Kolor;
        }
        public string AktualnFigura()
        {
            string Figura = ZeStosu.PokazFigure();
            return Figura;
        }
        public string CzyMoznaZagrac()
        {
            string AK = AktualnyKolor();
            string AF = AktualnFigura();
            string? Czy;


            if (ZReki.PokazFigure() == AK)
                Czy = "tak";
            if (ZReki.PokazKolor() == ZeStosu.PokazKolor())
                Czy = "tak";
            else Czy = "Nie";
            return Czy;
        }
    }
    public class Tura
    {
        public Tura() { }


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
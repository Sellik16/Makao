using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makao
{
    class Sprawdz
    {
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
            ZReki = x;
            Kolor = y;

            if (ZReki.PokazFigure() == AK)
                Czy = "tak";
            if (ZReki.PokazKolor() == ZeStosu.PokazKolor())
                Czy = "tak";
            else Czy = "Nie";
            return Czy;
        }
    }
    public class Akcja
    {
        Stos stos = new Stos();
        string As()
        {
            return "Wybierz kolor!";
            //trzeba wyświetlić wszystkie kolory asów
            //gracz klika kolor i wybiera w jakim kolorze musi być karta kolejnego gracza

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makao
{
    class Akcja
    {
        public Karta ZReki { get; set; }
        public Karta ZeStosu { get; set; }
        
        public Akcja() 
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
        public bool CzyMoznaZagrac(Karta x, Karta y)
        {
            bool Czy = false;
            ZReki = x;
            ZeStosu = y;

            if (ZReki.PokazFigure() == ZeStosu.PokazFigure())
                Czy = true;
            if (ZReki.PokazKolor() == ZeStosu.PokazKolor())
                Czy = true;

            return Czy;
        }
        
    }
}

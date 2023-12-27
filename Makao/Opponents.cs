using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makao
{
    public class Opponents
    {
        private Talia talia;
        private Stos stack;
        private int aktualnyGracz;
        private Karta karta;

        public Opponents(Talia talia, Stos stack, Karta shuffle)
        {
            this.talia = talia;
            this.stack = stack;
            this.karta = shuffle;
            this.aktualnyGracz = 0;
        }

        public void zmianaTury()
        {
            Console.WriteLine($"Ruch przeciwnika {aktualnyGracz + 1}...");

            int IdKarty = wybierzKarte();
            if (IdKarty != -1)
            {
                string karta = talia.Karty[IdKarty].PokazFigure() + " " + talia.Karty[IdKarty].PokazKolor();
                Console.WriteLine($"Przeciwnik {aktualnyGracz + 1} kładzie kartę: {karta}");
                stack.Tasuj();
                stack.Stosik.Push(IdKarty);
            }
            else
            {
                Console.WriteLine($"Przeciwnik { + 1} dobiera kartę...");
                stack.Tasuj();
                stack.Dobierz();
            }

            zmianaGracza();
        }

        public void symulacjaTuryPrzeciwnika()
        {
            // Symulacja kliknięcia tury przeciwnika
            zmianaTury();
        }

        private int wybierzKarte()
        {
            foreach (var karta in talia.Karty.Select((value, index) => new { value, index }))
            {
                if (sprawdzaZagranaKarte(karta.index))
                {
                    return karta.index;
                }
            }

            return -1;
        }

        private bool sprawdzaZagranaKarte(int IdKarty)
        {
            if (stack.Podejrzyj() == null)
            {
                return true;
            }

            var topCard = talia.Karty[stack.Stosik.Peek()];

            

            return topCard.PokazKolor() == talia.Karty[IdKarty].PokazKolor()
                   || topCard.PokazFigure() == talia.Karty[IdKarty].PokazFigure();
        }



        private void zmianaGracza()
        {
            aktualnyGracz = (aktualnyGracz + 1) % 2;
        }
    }
}


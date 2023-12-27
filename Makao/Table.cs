using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;


namespace Makao
{
    public class Table
    {
        private Stos stack;
        private Opponents[] opponents;
        private int aktualnyGracz;

        public Table(Stos stack, Opponents[] opponents)
        {
            this.stack = stack;
            this.opponents = opponents;
            this.aktualnyGracz = 0;
        }

        public void wyświetlStanStołu()
        {
            Console.WriteLine("Aktualny stan stołu:");
            Console.WriteLine($"Liczba kart przeciwnika 1: {opponents[0].CountCards()}");
            Console.WriteLine($"Liczba kart przeciwnika 2: {opponents[1].CountCards()}");
            Console.WriteLine($"Ostatnia karta na stosie: {stack.Podejrzyj()}");
        }

        public void zagraj()
        {
            while (true)
            {
                wyświetlStanStołu();
                Console.WriteLine($"Ruch gracza {aktualnyGracz + 1}...");

                if (stack.Ile() == 0)
                {
                    // Ktoś wygrał
                    if (opponents[aktualnyGracz].CountCards() == 0)
                    {
                        Console.WriteLine($"Gracz {aktualnyGracz + 1} wygrał!");
                    }
                    else
                    {
                        Console.WriteLine($"Gracz {aktualnyGracz + 1} ma 'Makao'!");
                    }

                    Console.WriteLine("Koniec gry!");
                    break;
                }

                if (aktualnyGracz == 0) // Gracz
                {
                    ruchGracza();
                }
                else // Przeciwnicy
                {
                    opponents[aktualnyGracz - 1].zmianaTury();
                }

                zmianaGracza();
            }

            // Koniec gry, sprawdzenie przegranej gracza
            sprawdzWynikGry();
        }

        private void zmianaGracza()
        {
            aktualnyGracz = (aktualnyGracz + 1) % (opponents.Length + 1);
        }

        private void sprawdzWynikGry()
        {
            // Sprawdzenie, czy gracz przegrał
            if (opponents[0].CountCards() == 0)
            {
                Console.WriteLine($"Przegrałeś, ty i gracz {opponents[1].GetPlayerIndex() + 1}!");
            }
            else if (opponents[1].CountCards() == 0)
            {
                Console.WriteLine($"Przegrał gracz {opponents[0].GetPlayerIndex() + 1}!");
            }
        }

        private void ruchGracza()
        {
            // Logika ruchu naszego gracza
        }
    }
}

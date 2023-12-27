using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Makao
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            try
            {
                //wyświetlanie pierwszego asa w tali
                Talia talia = new Talia();
                Stos stos = new Stos();
                Stos zuzyte = new Stos();
                Tura tura = new Tura();
                Sprawdz sprawdz = new Sprawdz();
                
                int[]? TaliaG = stos.Gracz();
                int[]? TaliaP1 = stos.Gracz();
                int[]? TaliaP2 = stos.Gracz();
                int ZeStosu = stos.DobierzInt();
                bool wygrana = false;
                int rozmiarG = 0;
                int rozmiarP1 = 0;
                int rozmiarP2 = 0;
                do
                {
                    Obecna.Text = "Karta na stosie = " + stos.IntNaString(ZeStosu);
                    //gracz
                    int[] GMoze = sprawdz.KtoreKarty(ZeStosu, TaliaG);
                    rozmiarG = GMoze.Length;
                    Skrol.Text += "\nWszystkie karty w ręcę: ";
                    for (int i = 0; i < TaliaG.Length; i++)
                    {
                        Skrol.Text += stos.IntNaString(TaliaG[i])+" - ";
                    }
                    Czwarty.Text += "\nMożna zagrać: ";
                    for (int i = 0; i < GMoze.Length; i++)
                    {
                        Czwarty.Text += stos.IntNaString(GMoze[i]) + " - ";
                    }
                    
                    Trzeci.Text += "\nliczba kart gracza, które można położyć: " + rozmiarG;
                    
                    
                    //przeciwnik1
                    int[] P1Moze = sprawdz.KtoreKarty(ZeStosu, TaliaP1);
                    rozmiarP1 = P1Moze.Length;
                    Pierwszy.Text += "\nliczba kart Przeciwnika 1, które można położyć: " + rozmiarP1;




                    //PRZECIWNIK2
                    int[] P2Moze = sprawdz.KtoreKarty(ZeStosu, TaliaP2);
                    rozmiarP2 = P2Moze.Length;
                    Drugi.Text += "\nliczba kart Przeciwnika 2, które można położyć: " + rozmiarP2;
                }
                while (wygrana);


                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}");
            }

        }

      
    }
}

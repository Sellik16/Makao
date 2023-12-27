using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Makao
{
    public partial class MainWindow : Window
    {
        //wyświetlanie pierwszego asa w tali

        internal bool CzyKlik = false;
        public Talia talia = new Talia();
        public Stos stos = new Stos();
        public Tura tura = new Tura();

        int[] TaliaG;
        int[] TaliaP1;
        int[] TaliaP2;
        int ZeStosu;
        public MainWindow()
        {
            InitializeComponent();

            try
            {
                InicjalizujRundy();
                RozegrajRunde();
                if (CzyKlik)
                {
                    TaliaG[TaliaG.Length] = stos.DobierzInt();
                    CzyKlik = false;
                    RozegrajRunde();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}");
            }

        }
        void InicjalizujRundy()
        {
            TaliaG = stos.Gracz();
            TaliaP1 = stos.Gracz();
            TaliaP2 = stos.Gracz();
            ZeStosu = stos.DobierzInt();
        }

        void RozegrajRunde()
        {
            Sprawdz sprawdz = new Sprawdz();
            int ZeStosu = stos.DobierzInt();
            bool wygrana = false;
            int rozmiarG = 0;
            int rozmiarP1 = 0;
            int rozmiarP2 = 0;

            Obecna.Text = "Karta na stosie: \n" + stos.IntNaString(ZeStosu);
            //gracz
            int[] GMoze = sprawdz.KtoreKarty(ZeStosu, TaliaG);
            rozmiarG = GMoze.Length;
            Skrol.Text += "\nWszystkie karty w ręcę: ";
            for (int i = 0; i < TaliaG.Length; i++)
            {
                Skrol.Text += stos.IntNaString(TaliaG[i]) + " - ";
            }
            Czwarty.Text += "\nMożna zagrać: ";
            for (int i = 0; i < GMoze.Length; i++)
            {
                Czwarty.Text += stos.IntNaString(GMoze[i]) + " - ";
            }

            Trzeci.Text += "\nliczba kart gracza, które można położyć: " + rozmiarG;

            

            //przeciwnik1
            int[] P1Moze = sprawdz.KtoreKarty(ZeStosu, TaliaP1);
            rozmiarP1 = TaliaP1.Length;
            Pierwszy.Text += "\nliczba kart Przeciwnika 1: " + rozmiarP1;




            //PRZECIWNIK2
            int[] P2Moze = sprawdz.KtoreKarty(ZeStosu, TaliaP2);
            rozmiarP2 = TaliaP2.Length;
            Drugi.Text += "\nliczba kart Przeciwnika 2: " + rozmiarP2;

            //koniec pętli
            wygrana = (TaliaG.Length == 0 || TaliaP1.Length == 0 || TaliaP2.Length == 0);

        }
        void Dob_Click(object sender, RoutedEventArgs e)
        {
            CzyKlik = true;
        }

    }
}

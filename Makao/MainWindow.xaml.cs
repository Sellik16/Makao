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
        internal bool Kladz = false;
        internal bool Dobiez = false;
        public Talia talia = new Talia();
        public Stos stos = new Stos();
        public Stos zuzyte = new Stos();
        public Tura tura = new Tura();
        public Sprawdz sprawdz = new Sprawdz();
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

            //dobieranie do talii gracza jednej karty
            
            int[] p1t = sprawdz.KtoreKarty(ZeStosu, TaliaP1);
            int[] p2t = sprawdz.KtoreKarty(ZeStosu, TaliaP2);

            int p1 = p1t.Length;
            int p2 = p2t.Length;
            if (Kladz)
            {

                ZagrajKarte(TaliaG);
                Kladz = false;
            }
            if (Dobiez)
            {
                TaliaG = stos.DobierzDo(TaliaG);
                Dobiez = false;
            }
            if (CzyKlik)
            {
                if (p1 > 0)
                {
                    ZagrajKarte(TaliaP1);
                }
                else
                {
                    TaliaP1 = stos.DobierzDo(TaliaP1);
                }

                if (p2 > 0)
                {
                    ZagrajKarte(TaliaP2);
                }
                else
                {
                    TaliaP2 = stos.DobierzDo(TaliaP2);
                }
                CzyKlik = false;
            }

            
            bool wygrana = false;
            int rozmiarG = 0;
            int rozmiarP1 = 0;
            int rozmiarP2 = 0;

            Obecna.Text = p1 +" "+ p2 + "\nKarta na stosie: \n" + stos.IntNaString(ZeStosu);
            //gracz
            
            
            int[] GMoze = sprawdz.KtoreKarty(ZeStosu, TaliaG);
            rozmiarG = GMoze.Length;
            Skrol.Text = "\nWszystkie karty w ręcę: ";
            for (int i = 0; i < TaliaG.Length; i++)
            {
                Skrol.Text += stos.IntNaString(TaliaG[i]) + " - ";
            }
            Czwarty.Text = "\nMożna zagrać: ";
            for (int i = 0; i < GMoze.Length; i++)
            {
                Czwarty.Text += stos.IntNaString(GMoze[i]) + " - ";
            }

            Trzeci.Text = "\nliczba kart gracza, które można położyć: " + GMoze.Length;

            

            //przeciwnik1
            int[] P1Moze = sprawdz.KtoreKarty(ZeStosu, TaliaP1);
            rozmiarP1 = TaliaP1.Length;
            Pierwszy.Text = "\nliczba kart Przeciwnika 1: " + rozmiarP1;




            //PRZECIWNIK2
            int[] P2Moze = sprawdz.KtoreKarty(ZeStosu, TaliaP2);
            rozmiarP2 = TaliaP2.Length;
            Drugi.Text = "\nliczba kart Przeciwnika 2: " + rozmiarP2;

            //koniec pętli
            wygrana = (TaliaG.Length == 0 || TaliaP1.Length == 0 || TaliaP2.Length == 0);

        }
        void Zuzyte()
        {
            zuzyte.Wstaw(ZeStosu);
        }
        void Remis()
        {
            Obecna.Text = "Remis: Brak kart na stosie";
            Skrol.Text = "";
            Czwarty.Text = "";
            Trzeci.Text = "";
            Pierwszy.Text = "";
            Drugi.Text = "";
        }
        void Dob_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                stos.Podejrzyj();
                CzyKlik = true;
                Dobiez = true;
                RozegrajRunde();

            }
            catch (Exception ex) 
            { 
                try
                {
                    zuzyte.Tasuj();
                    stos = zuzyte;
                }
                catch { Remis(); }
            }
            
        }
        void PolozPierwszaKarte(object sender, RoutedEventArgs e)
        {
            if (sprawdz.KtoreKarty(ZeStosu, TaliaG).Length > 0)
            {
                CzyKlik = true;
                Kladz = true;
                RozegrajRunde();
            }
            
        }
        void ZagrajKarte(int[] Reka)
        {
            int[] kartyDoZagr = sprawdz.KtoreKarty(ZeStosu, Reka);

            if (kartyDoZagr.Length > 0)
            {
                int kartaDoPol = kartyDoZagr[0];
                Reka = Reka.Where(k => k != kartaDoPol).ToArray();
                zuzyte.Wstaw(ZeStosu);
                ZeStosu = kartaDoPol;
            }
        }
    }
}

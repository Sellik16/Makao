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
                string[]? TaliaG = stos.Gracz();
                string[]? TaliaP1 = stos.Gracz();
                string[]? TaliaP2 = stos.Gracz();


                int? Ile = stos.Ile();
                string T1 = "";
                string T2 = "";
                string T3 = "";
                foreach (string Karta in TaliaG)
                {
                    T1 = T1 + Karta;
                }
                foreach (string Karta in TaliaP1)
                {
                    T2 = T2 + Karta;
                }
                foreach (string Karta in TaliaP2)
                {
                    T3 = T3 + Karta;
                }
                hlwrd.Text =T1 + "\n" + T2 + "\n" + T3 + "\n" + "\nLiczba kart pozostałych na stosie: " + Ile;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}");
            }

        }
    }
}

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
                string? Start = stos.Dobierz();

                int? Ile = stos.Ile();
                
                hlwrd.Text ="Karta na stosie: " + Start + "\nLiczba kart pozostałych na stosie: " + Ile;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}");
            }

        }
    }
}

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
                zuzyte = stos;
                string[]? TaliaG = stos.Gracz();
                string[]? TaliaP1 = stos.Gracz();
                string[]? TaliaP2 = stos.Gracz();
                string? ZeStosu = stos.Dobierz();
                string? p1 = zuzyte.Podejrzyj();
                zuzyte.Tasuj();
                string? p2 = zuzyte.Podejrzyj();
                int? Ile = stos.Ile();
                
                hlwrd.Text =p1+" -- "+ p2 +"\n" + "Karta na stosie: " + ZeStosu + "\nLiczba kart pozostałych na stosie: " + Ile;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}");
            }

        }
    }
}

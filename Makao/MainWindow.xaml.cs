using System;
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
                Tasowanie tasowanie = new Tasowanie();
                string? w1 = tasowanie.Dobierz();
                string? w2 = tasowanie.Dobierz();
                string? w3 = tasowanie.Dobierz();
                string? w4 = tasowanie.Dobierz();

                int? i = tasowanie.Ile();
                int Index = 42;
                string DaneKarty = "Kolor: " + talia.Karty[Index].PokazKolor()+ "\nFigura: " + talia.Karty[Index].PokazFigure();
                hlwrd.Text = w1 + w2 + w3 + w4 + "\nLiczba kart pozostałych na stosie: " + i;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}");
            }

        }
    }
}

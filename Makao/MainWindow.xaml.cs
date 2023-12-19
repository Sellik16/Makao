using System.Windows;
using System.Windows.Controls;

namespace Makao
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //wyświetlanie pierwszego asa w tali
            Talia talia = new Talia();
            int Index = 42;
            string DaneKarty = "Kolor: " + talia.Karty[Index].PokazKolor()+ "\nFigura: " + talia.Karty[Index].PokazFigure();
            hlwrd.Text = DaneKarty;


        }
    }
}

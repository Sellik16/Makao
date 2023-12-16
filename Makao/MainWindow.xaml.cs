using System.Windows;
using System.Windows.Controls;

namespace Makao
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Dobierz dobierzButton = new Dobierz(); 
            string dobTxt = dobierzButton.Text;
            hlwrd.Text = dobTxt;
        }
    }
}

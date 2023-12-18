using System.Windows;
using System.Windows.Controls;

namespace Makao
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Talia talia = new Talia();
            
            hlwrd.Text = talia.Asy[2].PokazKolor();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makao
{
    public class Button
    {
        public int Width { get; set; } = 100;
        public int Height { get; set; } = 50;
        public string Text { get; set; } = "Text";
    }

    public class WybierzKarte : Button
    {
        public  WybierzKarte()
        {
            Text = "Wybierz Kartę";
        }
    }
    public class Dobierz : Button
    {
        public Dobierz()
        {
            Text = "Dobierz Kartę";
        }
    }
}

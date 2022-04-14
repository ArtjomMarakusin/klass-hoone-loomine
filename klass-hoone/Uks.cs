using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klass_hoone
{
    public class Uks
    {
        public string Color { get; set; }

        public Uks(string color = "sinine")
        {
            Color = color;
        }

        public void NaitaInfo()
        {
            Console.WriteLine($"Mina olen uks, minu värv on {Color}"); // выводит информацию о цвете двери в консоль с помощью inimene.cs
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klass_hoone
{
    public class KorteriteMaja
    {
        public string Color { get; set; }

        public KorteriteMaja(string color = "sinine")
        {
            Color = color;
        }

        public void NaitaInfo()
        {
            Console.WriteLine($"Mina olen korteri maja, minu värv on {Color}");
        }
    }
}

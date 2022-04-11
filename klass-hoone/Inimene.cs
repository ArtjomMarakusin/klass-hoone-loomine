using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klass_hoone
{
    public class Inimene
    {
        private string nimi;
        public Hoone hoone { get; set; }

        public Inimene(string nimi)
        {
            this.nimi = nimi;
        }

        public void NaitaInfo()
        {
            Console.WriteLine($"Mina olen inimene, mimu nimi on {nimi}");
            Console.WriteLine("Hoone andmed:");
            hoone.NaitaInfo();
            Console.WriteLine("Ukse andmed:");
            hoone.GetUks().NaitaInfo();
            Console.WriteLine("Korteri andmed:");
            hoone.GetKorter().NaitaInfo();
        }
    }
}

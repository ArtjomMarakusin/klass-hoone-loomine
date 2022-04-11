using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klass_hoone
{
    static class Program
    {
        static void Main(string[] args)
        {

            EraMaja majake = new EraMaja();

            Inimene mees = new Inimene("Juku");
            majake.uks = new Uks("must");
            majake.korteri = new KorteriteMaja("valge");
            mees.hoone = majake;
            mees.NaitaInfo();

            Console.ReadLine();

        }
    }
}
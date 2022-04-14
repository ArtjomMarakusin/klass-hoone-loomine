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

            Inimene mees = new Inimene("Juku"); // имя человека
            majake.uks = new Uks("must"); // цвет двери
            majake.korteri = new KorteriteMaja("valge"); // цвет дома
            mees.hoone = majake;
            mees.NaitaInfo(); // выводит всю информацию в консоль

            Console.ReadLine();

        }
    }
}
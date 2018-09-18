using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasserTe16
{
    class Fighter
    {
        int hälsa;
        int uthållighet;
        int styrka;
        public String namn;

        public Fighter()
        {
            hälsa = 6;
            uthållighet = 10;
            styrka = 10;
            Console.WriteLine("Ange din fighters namn: ");
            namn = Console.ReadLine();
        }

        void Slå()
        {

        }

        void Hoppa()
        {

        }

        void Skydda()
        {

        }

        void Flytta()
        {

        }
    }
}

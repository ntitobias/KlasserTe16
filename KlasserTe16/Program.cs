using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasserTe16
{
    class Program
    {
        static void Main(string[] args)
        {

            Fighter player1 = new Fighter();
            Console.WriteLine("Välkommen " + player1.namn);

            Fighter player2 = new Fighter();
            Console.WriteLine("Välkommen du också " + player2.namn);

            Console.ReadKey();

        }
    }


}

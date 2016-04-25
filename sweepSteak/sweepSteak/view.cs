using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepSteak
{
    class view
    {
        Sweepstakes test1 = new Sweepstakes("name");

        public void menu()
        {
            Console.WriteLine("Input 1 to randomize a winner");
            Console.WriteLine("Input 2 to check availiable contestants");
            string x = Console.ReadLine();
            switch (x)
            {
                case "1":
                    test1.PickWinner();
                    break;
                case "2":
                    test1.PrintContestantInfo();
                    break;
                default:
                    menu();
                    break;
            }
        }
    }
}

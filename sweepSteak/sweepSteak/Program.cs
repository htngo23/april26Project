using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepSteak
{
    class Program
    {
        static void Main(string[] args)
        {
            Sweepstakes test1 = new Sweepstakes("name");

            test1.PickWinner();
            Console.ReadLine();
        }
    }
}

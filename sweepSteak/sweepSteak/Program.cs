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
            view views = new view();

            views.menu();
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomSystems
{
    class Program
    {
        static void Main(string[] args)
        {
            SystemString strung = new SystemString();
            SystemArrayString arrayStrung = new SystemArrayString();
            SystemLinkList zelda = new SystemLinkList();
            CustomLinkedList ganon = new CustomLinkedList();

            //zelda.ToString();
            //zelda.Insert("T");
            //zelda.length();
            //zelda.Remove(2, 2);
            ganon.Insert("z");

            Console.ReadLine();
        
        }
    }
}

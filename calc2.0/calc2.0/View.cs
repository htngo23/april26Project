using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc2._0
{
    class View
    {
        Addition adds = new Addition();
        Subtraction subs = new Subtraction();
        Multiply mult = new Multiply();
        Divide divs = new Divide();
        numInputs puts = new numInputs();
        
        public void menu()
        {
            bool kitty = true;
            while (kitty)
            {
                Console.Clear();
                Console.WriteLine("Please select your type of operation");
                Console.WriteLine("Input 1 for Addtion");
                Console.WriteLine("Input 2 for Subtraction");
                Console.WriteLine("Input 3 for Multiplication");
                Console.WriteLine("Input 4 for Division");
                Console.WriteLine("Input 5 for Exit application");
                string cat = Console.ReadLine();
                switch (cat)
                {
                    case "1":
                        adds.addition(puts.firstNum(), puts.secondNum());
                        Console.ReadKey();
                        break;
                    case "2":
                        subs.subtraction(puts.firstNum(), puts.secondNum());
                        Console.ReadKey();
                        break;
                    case "3":
                        mult.multiply(puts.firstNum(), puts.secondNum());
                        Console.ReadKey();
                        break;
                    case "4":
                        divs.division(puts.firstNum(), puts.secondNum());
                        Console.ReadKey();
                        break;
                    case "5":
                        kitty = false;
                        break;
                    default:
                        menu();
                        break;

                }
            }

        }
    }
}

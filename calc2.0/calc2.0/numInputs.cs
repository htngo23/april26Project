using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc2._0
{
    class numInputs
    {
        public double firstNum()
        {
            Console.WriteLine("please input the FIRST number");
            double num1 = double.Parse(Console.ReadLine());
            return num1;
        }
        public double secondNum()
        {
            Console.WriteLine("please input the SECOND numer");
            double num2 = double.Parse(Console.ReadLine());
            return num2;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomSystems
{
    class SystemString:ICustomString
    {
        public string newWord;

        public string playWord(string x)
        {
            return x;
        }

        
            public void Insert(string stringToInsert)
        {
            Console.WriteLine("The original string is: '{0}'", stringToInsert);
            string changed = stringToInsert.Insert(4, " ");
            Console.WriteLine("The modified string is: '{0}'", changed);

        }

        public int length()
        {
            throw new NotImplementedException();
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            
        }

        public override string ToString()
        {

            return base.ToString();
        }
        
    }
}

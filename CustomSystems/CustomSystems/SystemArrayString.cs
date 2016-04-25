using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomSystems
{
    class SystemArrayString : ICustomString
    {
        public char[] arrayOfChar = { 'a', 'b' ,'c'};
        public string[] arrayOfString = { "a", "b", "c", "d", "e", "f" };

        public override string ToString()
        {
            string x = " ";
            foreach(char character in arrayOfChar)
            {
                x = char.ToString(character);
                Console.WriteLine("chars are :" + x); 
            }
            return x;
        }

                

        public void Insert(string stringToInsert)
        {
            List<string> charList = new List<string>();

            for (int i = 0; i <= 2; i++)
            {
                charList.Add(arrayOfString[i]);
                
            }
            charList.Add(stringToInsert);

            for (int i = 4; i < arrayOfString.Length; i++)
            {
                charList.Add(arrayOfString[i]);
            }
            foreach(string letters in charList)
            {
                Console.WriteLine(letters);
            }
        }

        public int length()
        {
            int x = arrayOfString.Length;
            Console.WriteLine(x);
            return x;
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            List<string> charList = new List<string>();
            for (int i = 0; i < startIndex; i++)
            {
                charList.Add(arrayOfString[i]);
            }
            int restart = startIndex + numCharsToRemove;
            for (int i = restart; i < arrayOfString.Length; i++)
            {
                charList.Add(arrayOfString[i]);
            }
            foreach(string letter in charList)
            {
                Console.WriteLine(letter);
            }
        }


    }

}

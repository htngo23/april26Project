using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomSystems
{
    class SystemLinkList : ICustomString
    {
        public LinkedList<char> mainList = new LinkedList<char>();
        public void addMainList()
        {
            mainList.AddFirst('a');
            mainList.AddLast('b');
            mainList.AddLast('c');
            mainList.AddLast('d');
            mainList.AddLast('e');
            mainList.AddLast('f');
            mainList.AddLast('x');
        }
        public override string ToString()
        {
            addMainList();
            string x = " ";
            foreach (char character in mainList)
            {
                x = char.ToString(character);
                Console.WriteLine("chars are :" + x);
            }
            return x;
        }

        public void Insert(string stringToInsert)
        {
            addMainList();
            LinkedList<char> charList = new LinkedList<char>();
            LinkedListNode<char> newNode;

            int daisy = 0;
            
            while (daisy <= 3)
            {
                newNode = mainList.First;
                mainList.RemoveFirst();
                charList.AddLast(newNode);
                daisy += 1;
            }
            char play = Convert.ToChar(stringToInsert);  //char.parse(ex.console.ReadLine())

            charList.AddLast(play);
            daisy = 0;
            while (daisy < mainList.Count)
            {
                newNode = mainList.First;
                mainList.RemoveFirst();
                charList.AddLast(newNode);
            }
            foreach(char x in charList)
            {
                Console.WriteLine(x);
            }
        }

        public int length()
        {
            addMainList();
            int x = mainList.Count;
            Console.WriteLine(x);
            return x;
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            addMainList();
            LinkedList<char> charList = new LinkedList<char>();
            LinkedList<char> removedList = new LinkedList<char>();
            LinkedListNode<char> newNode;
            int daisy = 0;
            while(daisy < startIndex)
            {
                newNode = mainList.Last;
                mainList.RemoveLast();
                charList.AddFirst(newNode);
                daisy += 1;
            }
            int sunFlower = 0;
            while(sunFlower < numCharsToRemove)
            {
                newNode = mainList.Last;
                mainList.RemoveLast();
                removedList.AddFirst(newNode);
                sunFlower += 1;
            }
            bool truth = true;
            while(truth)
            {
                newNode = mainList.Last;
                mainList.RemoveLast();
                charList.AddFirst(newNode);
                if(mainList.Count == 0)
                {
                    truth = false;
                }
            }
            foreach(char x in charList)
            {
                Console.WriteLine("This is the new list: " + x);
            }
            foreach(char x in removedList)
            {
                Console.WriteLine("These are the removed characters: " + x);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomSystems 
{
    class CustomLinkedList : ICustomString
    {
        List<char> mainList = new List<char>();

        public class Node
        {

            public char letter;
            public Node next; //what is this doing?
            public Node(char letter)
            {
                this.letter = letter;
                this.next = null;
            }
        }
        public void addMain()
        {
            mainList.Add('a');
            mainList.Add('b');
            mainList.Add('c');
        }
        //public override string ToString()
        //{
        //    addMain();
        //    Node head = new Node(mainList[0]);
            
        //    Node curr = head;

        //    for(int i = 1; i < mainList.Count; i++)
        //    {
        //        curr.next = new Node(mainList[i]);
        //        curr.next.ToString
        //        curr = curr.next;
        //    }
        //}
        public void Insert(string stringToInsert)
        {
            addMain();
            Node head = new Node(mainList[0]);
            Console.WriteLine(head.letter);
            head.next = new Node(mainList[1]);
            Console.WriteLine(head.next.letter);
            Node curr = head.next;
            curr.next = new Node(mainList[2]);
            Console.WriteLine(curr.next.letter);
            char x = char.Parse(stringToInsert);
            curr = curr.next;
            curr.next = new Node(x);
            Console.WriteLine(curr.next.letter);
        }
        public void Remove(int startIndex, int numCharsToRemove)
        {
            addMain();
            foreach(char z in mainList)
            {
                Console.WriteLine(z);
            }
            Node head = new Node(mainList[0]);
            Node curr = head;
            
            for(int i = 1; i < startIndex; i++)
            {
                curr.next = new Node(mainList[i]);
                curr = curr.next;
            }
            int x = startIndex + numCharsToRemove;
            for( int i = x; i < mainList.Count; i++)
            {
                curr.next = new Node(mainList[i]);
                curr = curr.next;
            }

        }

        public int length()
        {
            throw new NotImplementedException();
        }

    }
}

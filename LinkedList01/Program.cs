using System;

namespace LinkedList01
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedLinkedList list = new SortedLinkedList();               //created the list object of the SortedLinkedList class
            list.Add(56);
            list.Add(30);
            list.Add(40);
            list.Add(70);
            list.Display();
            Console.WriteLine();
            list.Sort();
            list.Display();



        }
    }
}

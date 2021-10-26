using System;

namespace LinkedList01
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Append(56);
            list.Append(30);
            list.Append(70);
            list.Display();
            Console.WriteLine();
            list.SearchAndInsert(30, 40);
            list.Display();


        }
    }
}

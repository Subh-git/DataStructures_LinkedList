using System;

namespace LinkedList01
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            //list.Add(70);
            //list.Add(30);
            //list.Add(56);
            list.Display();
            Console.WriteLine("");
            list.AddFirst(70);
            list.AddFirst(30);
            list.AddFirst(56);
            list.Display();


        }
    }
}

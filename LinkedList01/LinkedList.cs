using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList01
{
    public class LinkedList
    {
        internal Node head;      //cearting a head variable of the node class

        internal void Add(int data)        //the add method
        {
            Node node = new Node(data);    //creating a node object of the Node class 
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linked list", node.data);
        }

        internal void Display()          //the display method
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }

        internal void AddFirst(int data)                //the add method 
        {
            Node node = new Node(data);                 //creating a node object of the Node class 
            if (this.head == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.head;

            }
            this.head = node;
            Console.WriteLine("{0} inserted into linked list", node.data);

        }
    }
}

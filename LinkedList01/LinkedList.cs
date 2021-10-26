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
        internal void Append(int data)        //the append method it is similar to Add method or Add last
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
            Console.WriteLine("{0} apeended into linked list", node.data);
        }

        internal void InsertAt(int position, int data)                //this enables us to insert a node at any given position
        {
            Node node = new Node(data);                              //declaring a node object of node class
            if (position < 1)
                Console.WriteLine("Invalid psotion");
            else
            {
                Node temp = head;
                while (position != 2)                               //the while loop is such designed soo that it starts afer 1 count to enter at the speciifed part
                {
                    temp = temp.next;
                    position--;
                }
                node.next = temp.next;                             //linking the nodes
                temp.next = node;
               
            }

            
        }
        internal void MidInsert(int new_data)            //this method inserts data at the mid position
        {
            Node new_node = new Node(new_data);
            Node pos = head;
            int len = 0;
            //calculate the length of linked list
            while (pos != null)
            {
                len++;
                pos = pos.next;
            }
            //finding middle possition
            int count = ((len % 2) == 0) ? (len / 2) : (len + 1) / 2;
            pos = head;
            //pos is the pointer to the node after which
            //pos is the pointer to the node after which the new node to be insert
            while (count-- > 1)
            {
                pos = pos.next;
            }
            new_node.next = pos.next;
            pos.next = new_node;
        }

        internal void DeleteFirst()                //removes the first node by assigning the next node address and value to the head node.
        {
            if (this.head == null)
                Console.WriteLine("The  list is empty!");       //prints the statement when the list is empty
            
            Console.WriteLine("Deleted node: " + this.head.data);  //prints the deleted node
            this.head = this.head.next;                           
            
        }

        internal void DeleteLast()                          //this method deletes the last node from the linked list
        {
            if(this.head == null)                   
                Console.WriteLine("The  list is empty!");
            
            if(this.head.next == null)                                      //checks if there is just 1 element in the list
                Console.WriteLine("Only 1 element in the list");

            Node node = head;             
            while(node.next.next != null)                                 //it checks for 2 values and see's whether its null or not
            {
                node = node.next;
            }
            Console.WriteLine("The deleted node is: " + node.next.data);
            node.next = null;

        }
    
   
    }    
    
    
}

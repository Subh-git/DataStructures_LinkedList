using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList01
{
    public class Node
    {
        //creating a node class for the learning purpose
        public int data;                 //declaring an integer instance variable data
        public Node next;               //declaring a next variable as Node class being the reference data type
                                        //it is done so that next acts like a node itself with the functionalities of node class
        public Node(int data)           //constructor
        {
            this.data = data;

        }
        
    }
}

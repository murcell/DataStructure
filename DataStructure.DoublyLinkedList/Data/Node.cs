using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.DoublyLinkedList.Data
{
    class Node
    {
        public int Data { get; set; }
        public Node Prev { get; set; }
        public Node Next { get; set; }
       
        public Node(int data)
        {
            this.Data = data;
            Next = null;
            Prev = null;    
        }

    }
}

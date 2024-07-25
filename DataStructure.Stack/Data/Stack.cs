using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Stacks.Data
{
    class Stack
    {
        private Node _top;

        private int _count;
        public Stack() 
        {
            _top = null;
            _count = 0;
        }

        public Stack(int data) 
        {
            Node newNode = new Node(data);
            _top = newNode;
            _count = 1;
        }

        public void Push(int data)
        {
            Node newNode = new Node(data);

            if (_count == 0)
            {
                _top = newNode;
            }
            else
            {
                newNode.Next = _top;
                _top = newNode;
            }
            _count++;
        }

        public void PrintAll()
        {
            Console.WriteLine("Stack içeriği : ");
            Console.WriteLine("-------------------");
            Node temp = _top;

            while (temp != null)
            {
                Console.WriteLine($"{temp.Data}");
                temp = temp.Next;
            }
        }

        public void PrintTop()
        {
            Console.WriteLine($"Top : {_top.Data}" );
        }

        public void PrintCount()
        {
            Console.WriteLine($"Count : {_count}");
        }

        public Node Pop()
        {
            if (_count == 0)
            {
                return null;
            }
            else
            {
                Node removedNode = _top;

                _top = _top.Next;
                removedNode.Next = null;

                _count--;
                return removedNode;
            }
           
        }

        public bool IsEmpty()
        {
            return _count == 0; 
        }   
    
    }
}

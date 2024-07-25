using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Queues.Data
{
    class Queue
    {
        private Node _head;
        private Node _tail;
        private int _size;

        public Queue()
        {
            _head = null;
            _tail = null;
            _size = 0;
        }

        public Queue(int data)
        {
            Node newNode = new Node(data);

            _head = newNode;
            _tail = newNode;
            _size = 1;
        }

        public void Enqueue(int data)
        {
            Node newNode = new Node(data);
            if (_size == 0)
            {
                _head = newNode;
                _tail = newNode;
            }
            else
            {
                _tail.Next = newNode;
                _tail = newNode;
            }
            _size++;
        }

        public void PrintAll()
        {
            Console.WriteLine("Queue içeriği : ");
            Console.WriteLine("- - - - - - - - - ");
            Node iteratedNode = _head;
            while (iteratedNode != null)
            {
                Console.WriteLine(iteratedNode.Data);
                iteratedNode = iteratedNode.Next;
            }
        }

        public void PrintHead()
        {

            Console.WriteLine("Head : ");
          
            Console.WriteLine(_head.Data);
        }

        public void PrintTail()
        {
            Console.WriteLine("Tail : ");
            Console.WriteLine(_tail.Data);
        }

        public void PrintSize()
        {
            Console.WriteLine("Size : ");
            Console.WriteLine(_size);
        }

        public Node Dequeue()
        {
            if (_size == 0)
                return null;

            Node removedNode = _head;
            if (_size == 1)
            {
                _head = null;
                _tail = null;
            }
            else 
            {
                _head = _head.Next;
                removedNode.Next = null;
            }
           
            _size--;

            return removedNode;
        }

        public int Peek()
        {
            if (_size > 0)
                return _head.Data;
            else
                return -1;
        }

        public bool IsEmpty()
        {
            return _size == 0; 
        }     

    }
}

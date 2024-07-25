using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.DoublyLinkedList.Data
{
    class DoublyLinkedList
    {
        private Node _head;
        private Node _tail;
        private int _length;
        public DoublyLinkedList()
        {
            _head = null;
            _tail = null;
            _length = 0;
        }

        public DoublyLinkedList(int data)
        {
            Node newNode = new Node(data);
            _head = newNode;
            _tail = newNode;
            _length = 1;
        }

        public void AppendList(int data)
        {
            Node newNode = new Node(data);

            if (_length==0) 
            {
                _head = newNode;
                _tail = newNode;
               
            }

            _tail.Next = newNode;
            newNode.Prev = _tail;
            _tail = newNode;

            _length++;
        }

        public void PrintList()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Doubly Linked List İçeriği: ");
            Console.WriteLine("----------------------------");
            Node iteratedNode = _head;
            while (iteratedNode != null) 
            {
                Console.WriteLine(iteratedNode.Data);
                iteratedNode = iteratedNode.Next;
            }
            Console.WriteLine("----------------------------");
        }

        public void PrintLength()
        {
            Console.WriteLine(".............................");
            Console.WriteLine($"Doubly Linked List Length: {_length}");
            Console.WriteLine(".............................");
        }

        public void PrintHead()
        {
            Console.WriteLine(".............................");
            Console.WriteLine($"Doubly Linked List Head.Data: {_head.Data}");
            Console.WriteLine(".............................");
        }

        public void PrintTail()
        {
            Console.WriteLine(".............................");
            Console.WriteLine($"Doubly Linked List Tail.Data: {_tail.Data}");
            Console.WriteLine(".............................");
        }

        public Node DeleteLastNode()
        {
            if (_length == 0)
                return null;

            Node deletedNode = _tail;
            if (_length==1)
            {
               
                _head = null;
                _tail = null;

                return deletedNode;
            }

            _tail = _tail.Prev;
            _tail.Next = null;

            deletedNode.Prev = null;
          
            _length--;

            return deletedNode;
        }

        public Node DeleteFirstNode()
        {
            if (_length == 0)
                return null;

            Node deletedNode = _head;
            if (_length == 1)
            {

                _head = null;
                _tail = null;

                return deletedNode;
            }

            _head=_head.Next;
            _head.Prev = null;
            deletedNode.Next = null;
            _length--;
            return deletedNode;
        }

        public void AddFirst(int data)
        {
            Node addedNode = new Node(data);

            if (_length == 0)
            {
                _head=addedNode;
                _tail=addedNode;
            }

            addedNode.Next = _head;
            _head.Prev = addedNode;
            _head = addedNode;
            _length++;
        }

        public Node GetNode(int index)
        {
            if (index < 0 || index >= _length)
                return null;

            Node seardhedNode = _head;

            if(index < _length / 2)
            {
                //aramaya soldan başla
                for (int i = 0; i < index; i++)
                {
                    seardhedNode = seardhedNode.Next;
                }
            }
            else
            {
                // sağdan başla
                seardhedNode = _tail;
                for (int i = _length - 1; i > index; i--)
                {
                    seardhedNode= seardhedNode.Prev;
                }
            }

            return seardhedNode;
        }

        public void SetNode(int index, int data)
        {
            Node settedNode = GetNode(index);

            if (settedNode != null)
            {
                settedNode.Data = data;
            }
        }

        public bool InsertNode(int index, int data)
        {
            if (index < 0 && index > _length)
                return false;

            if (index == 0) // başa ekle
            {
                AddFirst(data);
                return true;
            }
            else if (index == _length) //sona ekle
            {
                AppendList(data);
                return true;
            }
            else 
            {
                Node newNode = new Node(data);
                Node prevNode = GetNode(index - 1);
                Node afterNode = GetNode(index);

                newNode.Prev = prevNode;
                newNode.Next = afterNode;

                prevNode.Next = newNode;
                afterNode.Prev = newNode;
                _length++;

                return true;
            }

        }

        public Node DeleteNode(int index)
        {
            if (index >= 0 && index < _length)
            {
                if (index == 0)
                    return DeleteFirstNode();

                if (index == _length)
                    return DeleteLastNode();

                Node deletedNode = GetNode(index);
                deletedNode.Next.Prev = deletedNode.Prev;
                deletedNode.Prev.Next = deletedNode.Next;
              
                deletedNode.Next = null;
                deletedNode.Prev = null;
                _length--;

                return deletedNode;
            }
            Console.WriteLine("idex parametreniz geçersiz.");
            return null;
        }
    }
}

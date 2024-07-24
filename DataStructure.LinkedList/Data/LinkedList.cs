using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.LinkedList.Data
{
    class LinkedList
    {
        private Node _head;
        private Node _tail;
        private int _length;

        public LinkedList()
        {
            _head = null;
            _tail = null;
            _length = 0;
        }

        public LinkedList(int data)
        {
            Node newNode = new Node(data);
            _head = newNode;
            _tail = newNode;
            _length = 1;
        }

        public void AppendList(int data)
        {
            Node newNode = new Node(data);
            if (_length == 0)
            {
                _head = newNode;
                _tail = newNode;
            }
            else 
            { 
                _tail.Next = newNode;
                _tail = newNode;
            }
            _length++;

        }

        public void PrintList() 
        {
            Console.WriteLine("Linked List içerisindeki node'lar : ");
            Console.WriteLine("--------------------------------------");
            Node temp = _head;
            while (temp != null) 
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }
            Console.WriteLine();
        }

        public void PrintLength()
        {
            Console.WriteLine($"LinkedList node sayısı : {_length}");
        }

        public void PrintHead()
        {
            if(_head!=null)
                Console.WriteLine($"Head node değeri : {_head.Data}");
        }

        public void Printtail()
        {
            if (_tail != null)
                Console.WriteLine($"Tail node değeri : {_tail.Data}");
        }

        public Node DeleteLastNode()
        {
            if (_length == 0)
                return null;

            Node temp = _head;
            Node last = _head;

            // sondan bir önceki elemanı buluyoruz.
            while (temp.Next != null)
            {
                last = temp;
                temp = temp.Next;
            }

            _tail = last;
            _tail.Next = null;

            // bir node varsa kontrolünü de yapmamız gerekiyor.
            if (_length == 1)
            {
                _head = null;
                _tail = null;
                _length--;
            }
            // silme işlemi yapıldığı için node sayısı 1 azaltılır.
            _length--;
            return temp;
        }

        public Node DeleteFirstNode()
        {
            if (_length == 0)
                return null;

            Node temp = _head;
            _head = _head.Next;
            temp.Next = null;

            if (_length == 1)
                _tail = null;

            _length--;
            return temp;
        }

        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            if (_length == 0)
            {
                _head = newNode;
                _tail = newNode;
            }
            else 
            { 
                newNode.Next = _head;
                _head = newNode;
            }
            _length++;  
        }

        public Node GetNode(int index) 
        {
            if (index>=0 && index<_length) 
            {
                Node temp = _head;
                for (int i = 0; i < index; i++) 
                { 
                    temp=temp.Next;
                }
                return temp;
            }
            return null;
        }

        public void SetNode(int index, int data)
        {
            Node temp = GetNode(index);
            
            if (temp != null)
            {
                temp.Data = data;
            }
        }

        public bool InsertNode(int index, int data)
        {
            if (index<0 && index>_length)
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
            else // arada bi yere ekle
            {
                // benim yazdığım bu da çalışıyor
                //Node newNode = new Node(data);
                //Node previous = GetNode(index - 1);
                //Node nextAfter = GetNode(index);
                //previous.Next = newNode;
                //newNode.Next = nextAfter;
                // _length++;
                //return true;

                // hocanın yazdığı
                Node newNode = new Node(data);
                Node previous = GetNode(index - 1);
                newNode.Next = previous.Next;
                previous.Next = newNode;
                _length++;
                return true;
            }
           
        }

        public Node DeleteNode(int index)
        {
            if (index >= 0 && index < _length)
            {
                if (index==0) 
                    return DeleteFirstNode();
                
                if (index==_length)
                    return DeleteLastNode();

                Node temp = GetNode(index-1);
                Node deleted = GetNode(index);

                temp.Next = deleted.Next;
                deleted.Next = null;
                _length--;

                return deleted;
            }
            Console.WriteLine("idex parametreniz geçersiz.");
            return null;
        }
    }
}

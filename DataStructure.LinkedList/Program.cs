using DataStructure.LinkedList.Data;
using System.Net.WebSockets;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DataStructure.LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Denemeler
            //Node _head;
            //Node _tail;
            //Node newNode = new Node(15);
            //_head = newNode;
            //_tail = newNode;

            //Node newNode2 = new Node(7);

            //_tail.Next = newNode2;
            //_tail = newNode2;

            //Node newNode3 = new Node(45);

            //_tail.Next = newNode3;
            //_tail = newNode3; 
            #endregion

            Data.LinkedList linkedList = new Data.LinkedList();
            linkedList.AppendList(12);
            linkedList.AppendList(7);
            linkedList.AppendList(25);
            linkedList.AppendList(46);
            linkedList.AppendList(1);
            linkedList.PrintList();

            //Console.WriteLine("Add first Node");
            //linkedList.AddFirst(1);
            //linkedList.PrintList();

            //Console.WriteLine("Get Node");
            //Node n = linkedList.GetNode(0);

            //if (n != null)
            //{
            //    Console.WriteLine(n.Data);
            //}
            //else 
            //{
            //    Console.WriteLine("Yanlış index");
            //}

            //Console.WriteLine("Set Node");
            //linkedList.SetNode(2, 100);
            //linkedList.PrintList();

            //Console.WriteLine("Insert Node");
            //linkedList.InsertNode(2, 75);
            //linkedList.PrintList();

            Console.WriteLine("delete Node");
            Node n = linkedList.DeleteNode(3);
            linkedList.PrintList();


            //if (n != null)
            //{
            //    Console.WriteLine(n.Data);
            //}
            //else
            //{
            //    Console.WriteLine("Yanlış index");
            //}





            //Console.WriteLine("Deletin first node...");
            //linkedList.DeleteFirstNode();
            //linkedList.DeleteLastNode();
            //linkedList.PrintList();
            //linkedList.DeleteLastNode();
            //linkedList.PrintList();
            //linkedList.DeleteLastNode();
            //linkedList.PrintList();
            //linkedList.DeleteLastNode();
            //linkedList.PrintList();
            //linkedList.DeleteLastNode();
            //linkedList.PrintList();

        }
    }
}

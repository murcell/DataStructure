

using DataStructure.DoublyLinkedList.Data;

namespace DataStructure.DoublyLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Data.DoublyLinkedList doublyLinkedList = new Data.DoublyLinkedList();
            doublyLinkedList.AppendList(12);
            doublyLinkedList.AppendList(7);
            doublyLinkedList.AppendList(5);
            doublyLinkedList.AppendList(125);
            doublyLinkedList.AppendList(74);
            doublyLinkedList.AppendList(39);
            //doublyLinkedList.AddFirst(44);
            //doublyLinkedList.AddFirst(125);
            //doublyLinkedList.AddFirst(62);
            doublyLinkedList.PrintList();


            doublyLinkedList.DeleteNode(2);
            doublyLinkedList.PrintList();
            //doublyLinkedList.InsertNode(3, 24);
            //doublyLinkedList.PrintList();

            //doublyLinkedList.SetNode(2, 55);
            //doublyLinkedList.PrintList();
            //Node n = doublyLinkedList.GetNode(4);
            //if (n == null)
            //    Console.WriteLine("index hatalı");
            //else
            //    Console.WriteLine($"node value : {n.Data}");

            //doublyLinkedList.PrintList();
            //doublyLinkedList.AddFirst(44);
            //doublyLinkedList.PrintList();


            //doublyLinkedList.PrintList();
            //doublyLinkedList.AddFirst(66);
            //doublyLinkedList.PrintList();
            //doublyLinkedList.PrintList();
            //doublyLinkedList.DeleteFirstNode();
            //doublyLinkedList.PrintList();

            //doublyLinkedList.PrintList();
            //doublyLinkedList.DeleteLastNode();
            //doublyLinkedList.PrintList();

            //doublyLinkedList.PrintLength();
            //doublyLinkedList.PrintHead();
            //doublyLinkedList.PrintTail();

            //Console.WriteLine("* * * * * ");

            //doublyLinkedList.AppendList(10);
            //doublyLinkedList.AppendList(83);

            //doublyLinkedList.PrintList();
            //doublyLinkedList.PrintLength();
            //doublyLinkedList.PrintHead();
            //doublyLinkedList.PrintTail();

        }
    }
}


using DataStructure.Stacks.Data;

namespace DataStructure.Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack örnekleri");
            Stack myStack = new Stack();
            myStack.Push(6);
            myStack.Push(14);
            myStack.Push(32);
            myStack.Push(21);
            myStack.PrintAll();
            Console.WriteLine("* * * * * *");

            Node removed = myStack.Pop();
            Console.WriteLine($"Silinen node : {removed.Data}");
            myStack.PrintAll();
            Console.WriteLine("* * * * * *");


            //Console.WriteLine("------");
            //myStack.PrintTop();
            //myStack.PrintCount();
            //Console.WriteLine("* * * * ");

            //myStack.Push(50);
            //myStack.PrintTop();
            //myStack.PrintCount();
            //myStack.PrintAll();
        }
    }
}

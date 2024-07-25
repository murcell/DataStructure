using DataStructure.Queues.Data;

namespace DataStructure.Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Queue denemeleri");

            Queue newQueue = new Queue();
            newQueue.Enqueue(7);
            newQueue.Enqueue(5);
            newQueue.Enqueue(12);
            newQueue.PrintAll();
            newQueue.PrintHead();
            newQueue.PrintTail();
        }
    }
}

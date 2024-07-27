using DataStructure.Graphs.Data;

namespace DataStructure.Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Graphs örnekleri");


            Graph graph = new Graph();
            graph.AddVertex(1);
            graph.AddVertex(2);
            graph.AddVertex(3);
            graph.AddVertex(4);
            graph.AddVertex(5);


            graph.AddEdge(1, 2);
            graph.AddEdge(1, 3);
            graph.AddEdge(2, 4);
            graph.AddEdge(2, 5);
            graph.AddEdge(3, 5);
            graph.AddEdge(4, 5);
            graph.PrintGraph();
            //Console.WriteLine("- - - - - - - - - - - - - - - - - -");
            //graph.RemoveVertex(2);
            //graph.PrintGraph();

            //graph.RemoveEdge(1, 2);
            //graph.RemoveEdge(1, 3);
            //graph.PrintGraph();
            //Console.WriteLine("***********************");
            //graph.RemoveEdge(4,5);
            //graph.PrintGraph();
        }
    }
}

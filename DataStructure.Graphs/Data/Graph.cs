using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Graphs.Data
{
    class Graph
    {
        private Dictionary<int, List<int>> adjcList;

        public Graph()
        {
            adjcList = new Dictionary<int, List<int>>();
        }

        public bool AddVertex (int vertex)
        {
            List<int> value;

            if (adjcList.TryGetValue(vertex, out value))
            {
                // bir value mevcut
                // bir grapha aynı verteksi bir daha eklemiyoruz
                return false;
            }
            else 
            {
                // ekleme işlemi burada yapılacak
                adjcList.Add(vertex, new List<int>());

                return true;
            }

        }

        public void PrintGraph()
        {
            foreach (var vertex in adjcList)
            {
                Console.Write($"{vertex.Key} : {{ ");
                Console.Write(string.Join(", ", vertex.Value));
                Console.WriteLine($" }}");

            }
        }

        public bool AddEdge(int vertex1, int vertex2) 
        { 
            
            if (adjcList.ContainsKey(vertex1) && adjcList.ContainsKey(vertex2))
            {
                adjcList[vertex1].Add(vertex2);
                adjcList[vertex2].Add(vertex1);

                return true;
            }
            else
                return false;
        }

        public bool RemoveEdge(int vertex1, int vertex2) 
        {
            if (adjcList.ContainsKey(vertex1) && adjcList.ContainsKey(vertex2))
            {
                adjcList[vertex1].Remove(vertex2);
                adjcList[vertex2].Remove(vertex1);

                return true;
            }
            else
                return false;
        }

        public bool RemoveVertex(int vertex) 
        {
            if (adjcList.ContainsKey(vertex)==false)
                return false;
           
            // silinmesi isten vertexe edge'i olan diğer vertexlerin
            // listeleri içinde silinecek vertexi bulup siliyoruz
            foreach (var relatedVertex in adjcList[vertex]) 
            { 
                adjcList[relatedVertex].Remove(vertex);
            }

            // silinecek vertex key değerini ve value değerini kaldırıyoruz
            adjcList.Remove(vertex);
            return true;
            //List<int> value;
            //if (!adjcList.TryGetValue(vertex, out value))
            //    return false;
            //else
            //{
            //    foreach (var vertex2 in value) 
            //    { 
            //    }
            //}

        }

    }
}

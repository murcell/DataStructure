using DataStructure.BSTTrees.Data;

namespace DataStructure.BSTTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search Tree Örnekleri");

            BinarySearchTree bst = new BinarySearchTree(52);
            bst.InsertNode(27);
            bst.InsertNode(15);
            bst.InsertNode(30);
            bst.InsertNode(78);
            bst.InsertNode(65);
            bst.InsertNode(53);
            //bst.InsertNode(80);
            //bst.InsertNode(3);

            //bst.DFSInOrderSearchPrintAll(bst.GetRoot());

            bst.BreathFirstSearch();

            //bst.DFSPreOrderSearchPrintAll(bst.GetRoot());
            //bst.DFSPostOrderSearchPrintAll(bst.GetRoot());

            //Node n = bst.DFSGetSpecificNode(27);
            //bst.DFSPostOrderSearchPrintAll(n);

            //Node n = bst.DFSGetSpecificNode(88);

            //if (n != null)
            //{
            //    Console.WriteLine($"{n.Data} numaralı node BST içinde bulundu");
            //}
            //else
            //{
            //    Console.WriteLine($"node BST içinde bulunamadı");
            //}


            //Node n = bst.DFSPreOrderSearchNode(bst.GetRoot(), 65);

            //if (n != null)
            //{
            //    Console.WriteLine($"{n.Data} numaralı node BST içinde bulundu");
            //}
            //else 
            //{
            //    Console.WriteLine($"node BST içinde bulunamadı");
            //}


            //Node n1 = bst.DFSPreOrderSearchNode(bst.GetRoot(), 70);
            //if (n1 != null)
            //{
            //    Console.WriteLine($"{n1.Data} numaralı node BST içinde bulundu");
            //}
            //else
            //{
            //    Console.WriteLine($"node BST içinde bulunamadı");
            //}

            //bst.GetSpecificNode(15);
            //Console.WriteLine(bst.GetRoot().Left.Left.Data);
            //Console.WriteLine("- - - - - ");
            //Console.WriteLine(bst.GetRoot().Right.Left.Data);
            //Console.WriteLine("- - - - - ");
            //Console.WriteLine(bst.GetRoot().Right.Right.Data);
        }
    }
}

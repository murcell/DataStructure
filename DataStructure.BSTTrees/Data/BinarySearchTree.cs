using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.BSTTrees.Data
{
    class BinarySearchTree
    {
        private Node _root;
        public BinarySearchTree()
        {
            _root = null;
        }

        public BinarySearchTree(int data)
        {
            _root = new Node(data);
        }

        // _root'u private olarak tanımladığım için
        // _root'u göstermek için test maçlı böyle bir method yaptık
        public Node GetRoot()
        {
            return _root;
        }

        public bool InsertNode(int data)
        {
            Node insertedNode = new Node(data);

            if (_root == null)
            {
                _root = insertedNode;
            }
            else
            {
                Node tmp = _root;
                while (true)
                {
                    if (insertedNode.Data == tmp.Data)
                        return false;

                    if (insertedNode.Data < tmp.Data)
                    {
                        if (tmp.Left == null)
                        {
                            tmp.Left = insertedNode;
                            return true;
                        }
                        tmp = tmp.Left;
                    }
                    else if (insertedNode.Data > tmp.Data)
                    {
                        if (tmp.Right == null)
                        {
                            tmp.Right = insertedNode;
                            return true;
                        }
                        tmp = tmp.Right;
                    }
                }
            }

            return true;
        }

        public Node DFSGetSpecificNode(int data)
        {
            if (_root == null)
            {
                return null;
            }
            if (_root.Data == data)
            {
                return GetRoot();
            }

            Node tmp = _root;
            while (true)
            {
                if (data == tmp.Data)
                    return tmp;
                else
                {
                    if (data < tmp.Data)
                    {
                        if (tmp.Left != null)
                            tmp = tmp.Left;
                        else
                            return null;
                    }
                    else if (data > tmp.Data)
                    {
                        if (tmp.Right != null)
                            tmp = tmp.Right;
                        else
                            return null;
                    }
                }

            }

        }

        // Bst'de nodelar arasında gezinme için
        // birden fazla algoritme var
        // BUnların bir tanesi 
        // DFS (Depth First Search)
        // DFS'te kendi içinde 3'e ayrılıyor
        // 1- Pre Order Algoritması
        // 2- Post Order Algoritması
        // 3- In Order Algoritması

        // DFS - Pre Order Algoritması
        public void DFSPreOrderSearchPrintAll(Node node)
        {
            Console.Write($"{node.Data} ,");

            if (node.Left != null)
            {
                DFSPreOrderSearchPrintAll(node.Left);
            }

            if (node.Right != null)
            {
                DFSPreOrderSearchPrintAll(node.Right);
            }
        }

        public Node DFSPreOrderSearchNode(Node node, int searchedValue)
        {
            if (node == null || searchedValue == node.Data)
                return node;

            if (searchedValue < node.Data)
            {
                return DFSPreOrderSearchNode(node.Left, searchedValue);
            }
            else
            {
                return DFSPreOrderSearchNode(node.Right, searchedValue);
            }

        }

        public void DFSPostOrderSearchPrintAll(Node node)
        {
            if (node.Left != null)
            {
                DFSPostOrderSearchPrintAll(node.Left);
            }

            if (node.Right != null)
            {
                DFSPostOrderSearchPrintAll(node.Right);
            }
            Console.Write($"{node.Data} ,");
        }

        public void DFSInOrderSearchPrintAll(Node node)
        {
            if (node.Left != null)
            {
                DFSInOrderSearchPrintAll(node.Left);
            }
            Console.Write($"{node.Data} ,");
            if (node.Right != null)
            {
                DFSInOrderSearchPrintAll(node.Right);
            }

        }

        public void BreathFirstSearch()
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(_root);

            while (queue.Count > 0)
            {
                Node node = queue.Dequeue();
                Console.Write($"{node.Data} ,");
                if (node.Left != null)
                    queue.Enqueue(node.Left);
                
                if(node.Right!=null)
                    queue.Enqueue(node.Right);
            }
        }
    }
}

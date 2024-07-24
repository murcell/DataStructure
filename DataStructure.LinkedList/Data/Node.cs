namespace DataStructure.LinkedList.Data
{
    class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }

        public Node() { }

        public Node(int data)
        {
            this.Data = data;
            Next = null;
        }
    }
}

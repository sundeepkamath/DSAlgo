namespace LinkedLists
{
    public class Node
    {
        public int Data { get; set; }
        public Node Link { get; set; }

        public Node(int i)
        {
            this.Data = i;
        }
    }
}

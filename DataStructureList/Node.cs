namespace DataStructureList
{
    public class Node
    {
        private Passenger passenger;
        private Node nextNode;
        private Node previousNode;

        public Node()
        {
            nextNode = null;
            previousNode = null;
            passenger = null;
        }

        public Passenger Passenger { get => passenger; set => passenger = value; }
        public Node NextNode { get => nextNode; set => nextNode = value; }
        public Node PreviousNode { get => previousNode; set => previousNode = value; }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureList
{
    class Node
    {
        Passenger passenger;
        Node nextNode;

        internal Node NextNode { get => nextNode; set => nextNode = value; }
        internal Passenger Passenger { get => passenger; set => passenger = value; }
    }
}

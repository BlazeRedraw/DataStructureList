namespace DataStructureList
{
    public class List
    {
        public Node firstElement;
        public List list;
        public Node lastElement;

        public List()
        {
            firstElement = null;
        }

        public Node FirstElement { get => firstElement; set => firstElement = value; }

        public void Add(Node element) // O(1)
        {
            if (firstElement == null)
            {
                firstElement = element;
            }
            else
            {
                firstElement.PreviousNode = element;// 4->3
                element.NextNode = firstElement;//3->4
                firstElement = element;//FE = 3
            }
        }

        //3 4 5 6 98 7
        //Delete = 90
        //FE = 3
        public bool Delete(Node element)
        {
            if (firstElement == element)
            {
                firstElement = firstElement.NextNode;
                firstElement.PreviousNode = null;
                return true;
            }
            else
            {
                Node temp = firstElement;
                while (temp != null)
                {
                    if (temp == element)
                    {
                        temp.PreviousNode.NextNode = temp.NextNode; //4 -> 5 -> 6 => 4 -> 6
                        temp.NextNode.PreviousNode = temp.PreviousNode; //4 <- 5 <- 6 => 4 <- 6
                        return true;
                    }
                    temp = temp.NextNode;
                }
                return false;
            }
        }

        public Node Search(string id)
        {
            if (firstElement.Passenger.IsFound(id))
            {
                return firstElement;
            }
            else
            {
                Node temp = firstElement;
                while (temp.NextNode != null)
                {
                    if (temp.NextNode.Passenger.IsFound(id))
                    {
                        return temp.NextNode;
                    }
                    else
                    {
                        temp = temp.NextNode;
                    }
                }
                return null;
            }
        }

        public bool Update(Node element, string id) //Parte de la tarea
        {
            element = Search(element.Passenger.Id);

            if (element != null)
            {
                element.Passenger.Id = id;
                return true;
            }

            return false;
        }

        //3 4 5 6 98 7
        //Next(5) -> 
        public Node Next(string id)
        {
            Node temp = Search(id);
            if (temp != null)
            {
                return temp.NextNode;
            }
            return null;
        }

        //Previous(7) -> 
        public Node Previous(string id)
        {
            Node temp = Search(id);
            if (temp != null)
            {
                return temp.PreviousNode;
            }

            if (firstElement == null)
            {
                return null;
            }
            else
            {
                if (firstElement.Passenger.IsFound(id))
                {
                    return null;
                }
                else
                {
                    temp = firstElement;
                    while (temp.NextNode != null)
                    {
                        if (temp.NextNode.Passenger.IsFound(id))
                        {
                            return temp;
                        }
                        temp = temp.NextNode;
                    }
                    return null;
                }
            }
        }
    }
}

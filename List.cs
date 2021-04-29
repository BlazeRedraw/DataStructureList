using System;
using System.Collections;
using System.Text;

namespace DataStructureList
{
    internal class List
    {
        private Node firstElement;

        public List()
        {

        }

        internal Node FirstElement { get => firstElement; set => firstElement = value; }

        public void Add(Node element)
        {
            if (firstElement == null)
            {
                firstElement = element;
            }
            else
            {
                element.NextNode = firstElement;
                firstElement = element;
            }
        }

        public bool Delete(Node element)
        {
            if (firstElement == element)
            {
                firstElement = firstElement.NextNode;
            }
            else
            {
                Node temp = firstElement.NextNode;
                while (temp != null)
                {
                    if (temp.NextNode == element)
                    {
                        temp.NextNode = temp.NextNode.NextNode;
                        return true;
                    }
                    else
                    {
                        temp = temp.NextNode;
                    }
                }
                temp.NextNode = element;
            }
            return false;
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

        public bool Update(Node element, string id)
        {
            //Update the element with the given id
            Node node = Search(id);

            if (node != null)
            {
                node = element;
                return true;
            }
            else
            {
                return false;
            }
        }

        public Node Next(String id)
        {
            Node temp = Search(id);
            if (temp != null)
            {
                return temp.NextNode;
            }
            return null;
        }

        public Node Previous(String id)
        {
            Node temp = Search(id);
            if (temp != null)
            {
                return temp.NextNode;
            }
            return null;
        }
    }
}

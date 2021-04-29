using System.Collections;

namespace DataStructureList
{
    internal class Queue
    {
        internal Stack myStack;

        public Queue()
        {

        }

        public int Pop()
        {
            myStack.Pop();
            return 0;
        }

        public int Top()
        {
            return (int)myStack.Peek();
        }

        public void Push(int element)
        {
            myStack.Push(element);
        }

        public int Size()
        {
            return myStack.Count;
        }

    }
}

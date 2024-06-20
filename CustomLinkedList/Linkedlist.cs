using System;

namespace CustomLinkedList
{
    public class LinkedList<Link>
    {
        public Node<Link> First { get; private set; }
        public Node<Link> Last { get; private set; }
        public int Count { get; private set; }

        public LinkedList()
        {
            this.First = null;
            this.Last = null;
        }

        public void AddFirst(Node<Link> data)
        {
            if (First == null)
            {
                First = data;
                Last = data;
            }
            else
            {
                data.Next = First;
                First = data;
            }
            Count++;
        }

        public void AddLast(Node<Link> data)
        {
            if (First == null)
            {
                First = data;
                Last = data;
            }
            else
            {
                Last.Next = data;
                Last = data;
            }
            Count++;
        }

        public void AddAfter(Node<Link> data, Node<Link> existingNode)
        {
            if (existingNode == Last)
            {
                Last = data;
            }
            data.Next = existingNode.Next;
            existingNode.Next = data;
            Count++;
        }

        public Node<Link> Find(Link target)
        {
            Node<Link> currentNode = First;
            while (currentNode != null && !currentNode.Data.Equals(target))
            {
                currentNode = currentNode.Next;
            }
            return currentNode;
        }

        public void RemoveFirst()
        {
            if (First != null)
            {
                First = First.Next;
                Count--;
                if (First == null)
                {
                    Last = null;
                }
            }
        }

        public void Remove(Node<Link> doomedNode)
        {
            if (doomedNode == null)
            {
                return;
            }

            if (doomedNode == First)
            {
                RemoveFirst();
                return;
            }

            Node<Link> previous = First;
            Node<Link> current = previous.Next;

            while (current != null && current != doomedNode)
            {
                previous = current;
                current = current.Next;
            }

            if (current != null)
            {
                previous.Next = current.Next;
                Count--;
                if (current == Last)
                {
                    Last = previous;
                }
            }
        }

        public void Traverse()
        {
            if (First == null)
            {
                Console.WriteLine("The list is empty.");
                return;
            }

            Console.WriteLine("First: " + First.Data);
            Console.WriteLine("Last: " + Last.Data);

            Node<Link> node = First;

            while (node != null)
            {
                Console.WriteLine(node.Data);
                node = node.Next;
            }
        }

        // Properties and methods...

        public bool Check(Link value)
        {
            Node<Link> currentNode = First;

            while (currentNode != null)
            {
                if (currentNode.Data.Equals(value))
                {
                    return true;
                }

                currentNode = currentNode.Next;
            }

            return false;
        }
        public int Index(Link value)
        {
            Node<Link> currentNode = First;
            int index = 0;

            while (currentNode != null)
            {
                if (currentNode.Data.Equals(value))
                {
                    return index;
                }

                currentNode = currentNode.Next;
                index++;
            }

            // If the value is not found, return -1
            return -1;
        }
    }
}

using CustomLinkedList;
using System;
namespace MyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomLinkedList.LinkedList<string> ll = new CustomLinkedList.LinkedList<string>();

            Node<string> a = new Node<string>("Fruit");
            ll.AddFirst(a);

            Node<string> b = new Node<string>("School");
            ll.AddFirst(b);

            Node<string> c = new Node<string>("Police station");
            ll.AddFirst(c);

            Node<string> d = new Node<string>("Power");
            ll.AddFirst(d);


            ll.Traverse();

            Console.WriteLine("Add After a");
            ll.AddAfter(new Node<string>("Apple"), a);
            ll.Traverse();

            bool result = ll.Check("Power");
            Console.WriteLine(result);

            int index = ll.Index("Power");
            Console.WriteLine(index);

            // Define the target node here
            Node<string> target = new Node<string>("Power");

            Console.WriteLine("\nremoving " + target.Data);
            ll.Remove(target);
            ll.Traverse();
        }
    }
}

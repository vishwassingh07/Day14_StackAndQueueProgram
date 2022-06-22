using System;
namespace StackAndQueueProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Stack and Queue program \n---------------------------------------");
            Stack stack = new Stack();
            Node node1 = new Node(70);
            Node node2 = new Node(30);
            Node node3 = new Node(56);

            stack.Push(node1);
            stack.Push(node2);
            stack.Push(node3);
            stack.DisplayStack();
            
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueueProgram
{
    public class Stack
    {
        LinkedList linkedlist;
        public Stack()
        {
            linkedlist = new LinkedList();
        }
        public void Push(Node node)
        {
            linkedlist.AddNode(node);
        }
        public void DisplayStack()
        {
            linkedlist.StackDisplay();
        }
        public void Peek()
        {
            var value = linkedlist.Head;
            Console.WriteLine(value.data);
        }
        public void Pop()
        {
            linkedlist.DeleteNodeAtFirst();
        }
    }
}

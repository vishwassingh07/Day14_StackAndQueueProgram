using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueueProgram
{
    public class Queue
    {
        LinkedList linkedlist = new LinkedList();
        
        public void Enqueuue(Node node)
        {
            linkedlist.AppendNode(node);
        }
        public void DisplayQueue()
        {
            linkedlist.QueueDisplay();
        }
        public void Top()
        {
            var value = linkedlist.Head;
            Console.WriteLine(value.data);
        }
        public void Dequeue()
        {
            linkedlist.DeleteNodeAtLast();
        }
    }
}

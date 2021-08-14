using System;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to stacks and Queues Program !");

            //LinkedListStack linkedListStack = new LinkedListStack();
            //linkedListStack.push(70);
            //linkedListStack.push(30);
            //linkedListStack.push(56);
            //linkedListStack.pop();
            //linkedListStack.peek();
            //linkedListStack.isEmpty();
            //linkedListStack.isFull();
            //linkedListStack.Display();
            LinkedListQueues linkedListQueues = new LinkedListQueues();
            linkedListQueues.Enqueue(56);
            linkedListQueues.Enqueue(30);
            linkedListQueues.Enqueue(70);
            linkedListQueues.Display();
            Console.WriteLine("------------------");
           
        }
    }
}

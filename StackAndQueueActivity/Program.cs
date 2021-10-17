using System;

namespace StackAndQueueActivity
{
    class Program
    {
        static void Main(string[] args)
        {

            //STACK            
            Stack<int> s = new Stack<int>();

            s.Push(8);
            s.Push(27);
            s.Push(19);

            Console.WriteLine("--STACK--");
            Console.WriteLine(s.Traverse());
            Console.WriteLine("Peek: " + s.Peek());
            Console.WriteLine("Pop: " + s.Pop());
            Console.WriteLine(s.Traverse());

            //QUEUE
            Queue<int> q = new Queue<int>();

            q.Enqueue(7);
            q.Enqueue(43);
            q.Enqueue(21);

            Console.WriteLine("--QUEUE--");
            Console.WriteLine("Traverse - \n" + q.Traverse());
            Console.WriteLine("Peek: " + q.Peek());
            Console.WriteLine("Pop: " + q.Dequeue());
            Console.WriteLine("Traverse - \n" + q.Traverse());
        }
    }
}

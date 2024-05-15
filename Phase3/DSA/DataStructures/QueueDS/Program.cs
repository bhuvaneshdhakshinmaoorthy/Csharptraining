using System;

namespace QueueDS
{
    class Program
    {
        public static void Main(string[] args)
        {
            CustomQueue<int> myQueue = new CustomQueue<int>();
            myQueue.Enqueue(11);
            myQueue.Enqueue(12);
            myQueue.Enqueue(13);
            myQueue.Enqueue(14);
            myQueue.Enqueue(15);
            // System.Console.WriteLine(myQueue.Dequeue());
            // System.Console.WriteLine(myQueue.Peek());
            foreach(int i in myQueue)
            {
                System.Console.WriteLine(i);
            }
        }
    }
}
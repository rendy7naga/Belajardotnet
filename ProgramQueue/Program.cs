using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //System pada Queue adalah FIFO
            Queue<int> myQueue = new Queue<int>();
            //Untuk menambah Queue menggunakan perintah Enqueue
            myQueue.Enqueue(1);
            Console.WriteLine(myQueue.Peek());
            myQueue.Enqueue(2);
            Console.WriteLine(myQueue.Peek());
            myQueue.Enqueue(3);
            int QueueItem = myQueue.Dequeue();
            Console.WriteLine(myQueue.Peek());

        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //system stack LIFO
            Stack<string> stack = new Stack<string>();
            //menambah data pada stack menggunakan Push
            stack.Push("a");
            Console.WriteLine(stack.Peek());
            stack.Push("b");
            Console.WriteLine(stack.Peek());
            stack.Push("c");
            Console.WriteLine(stack.Peek());
            stack.Push("d");
            //menghapus data terakhir yang di input menggunakan Pop
            string myStackData = stack.Pop();
            Console.WriteLine("Data yang di pop : " + myStackData);
            Console.WriteLine("data on top adalah : " + stack.Peek());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char setuju = 'T';
            do
            {
                Console.Write("Ingin menjalankan program While? (Y/T)");
                setuju = Convert.ToChar(Console.ReadLine());
            }
            while (setuju != 'Y');

            Console.WriteLine("Anda menjalankan perulangan Do While, terimakasih");
            Console.ReadLine();
        }
    }
}

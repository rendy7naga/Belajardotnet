using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramWhile_DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char setuju = 'T';
            while (setuju != 'Y')
            {
                Console.WriteLine("Ingin menjalankan program While? (Y/T)");
                setuju=Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("Anda menjalankan perulangan While, terimakasih");
            Console.ReadLine();
        }
    }
}

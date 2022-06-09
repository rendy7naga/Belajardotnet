using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramIfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, graduation;

            Console.Write("Nama : ");
            name = Console.ReadLine();
            Console.Write("Tamatan :");
            graduation = Console.ReadLine();

            if (graduation == "ilmu komputer")
            {
                Console.WriteLine("Hello " + name + " Fakultas anda adalah : " + graduation);
            }
            else if (graduation == "sistem informasi")
            {
                Console.WriteLine("Hello " + name + " Jurusan anda adalah : " + graduation);
            }
            else
            {
                Console.WriteLine("Hello " + name + " " + graduation + " tidak terdaftar di ilmu komputer");
            }
        }
    }
}

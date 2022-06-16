using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PemrogramanLoopingFor
{
    class Program
    {

        static void Main(string[] args)
        {
            string x;
            int y;
            Console.Write("Masukkan nama Universitas : ");
            x =Console.ReadLine();
            Console.Write("Masukkan jumlah fakultas : ");
            y= Convert.ToInt16(Console.ReadLine());
            string[] fakultas = new string[y]; 
            Console.WriteLine("--------------------------------------------");
            for (int i = 0; i < y; i++)
            {
                Console.Write("Masukkan nama Fakultas : ");
                fakultas[i] = Console.ReadLine();
                Console.WriteLine();
            }
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Selamat datang di Universitas " + x);
            for (int i = 0; i < y ; i++)
            {
                Console.WriteLine("Fakultas : " + fakultas[i]);
            }
        }
    }
}

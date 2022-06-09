using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramReadLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, role;
            int A, B;

            Console.Write("Nama : ");
            name = Console.ReadLine();
            Console.Write("Jabatan :");
            role = Console.ReadLine();
            Console.Write("Masukan Nilai A :");
            A = Convert.ToInt16(Console.ReadLine());
            Console.Write("Masukan Nilai B :");
            B = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("Nama : " + name);
            Console.WriteLine("Role : " + role);
            Console.WriteLine("Penjumlahan A + B = " + (A + B));
            Console.WriteLine("Pengurangan A - B = " + (A - B));
            Console.WriteLine("Perkalian A * B = " + (A * B));
            Console.WriteLine("Pembagian A / B = " + ( Convert.ToDecimal( A ) / Convert.ToDecimal( B )));
            Console.WriteLine("Modulus A / B = " + (Convert.ToDecimal(A) % Convert.ToDecimal(B)));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramSwitchStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, aritmatika;
            Console.WriteLine("------- Ini adalah contoh Switch Statement untuk Operator Arimatika ---------");
            Console.Write("Masukan Nilai A : ");
            A = Convert.ToInt16(Console.ReadLine());
            Console.Write("Masukan Nilai B : ");
            B = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("-----------------------------------------------------------------------------");
            
            Console.WriteLine("1 Penjumlahan ");
            Console.WriteLine("2 Pengurangan ");
            Console.WriteLine("3 Perkalian ");
            Console.WriteLine("4 Pembagian ");
            Console.WriteLine("5 Modulus (sisa bagi)");
            Console.WriteLine("Silahkan pilih operator aritmatika yang diinginkan? (1 s/d 5) ");
            aritmatika = Convert.ToInt16(Console.ReadLine());

            switch(aritmatika)
            {
                case 1:
                    Console.WriteLine(A + " + " + B + " = " + A + B);
                    break;
                case 2:
                    Console.WriteLine(A + " - " + B + " = " + (A - B));
                    break;
                case 3:
                    Console.WriteLine(A + " * " + B + " = " + A * B);
                    break;
                case 4:
                    Console.WriteLine(A + " / " + B + " = " + (Convert.ToDecimal(A) / Convert.ToDecimal(B)));
                    break;
                case 5:
                    Console.WriteLine(A + " mod " + B + " = " + (Convert.ToDecimal(A) % Convert.ToDecimal(B)));
                    break;
                default: Console.WriteLine("Error!! Pemilihan operator hanya 1 s/d 5!");
                    break;
            }
        }
    }
}

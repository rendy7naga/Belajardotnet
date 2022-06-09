using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnBasic
{
    internal class ProgramTipeData
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Contoh TipeData int");
            int A = 5;
            int B = 10;
            int C = A + B;
            Console.WriteLine("A = 5");
            Console.WriteLine("B = 10");
            Console.WriteLine("A + B = " + C);

            Console.WriteLine();

            Console.WriteLine("Contoh TipeData Double");
            double NilaiC = Convert.ToDouble(A) / Convert.ToDouble(B);
            Console.WriteLine("A = 5");
            Console.WriteLine("B = 10");
            Console.WriteLine("A / B = " + NilaiC);

            Console.WriteLine();

            Console.WriteLine("Contoh TipeData Char");
            char HurufAwal = 'A';
            char HurufAkhir = 'Z';
            Console.WriteLine("Huruf awal alfabet adalah : " + HurufAwal);
            Console.WriteLine("Huruf akhir alfabet adalah : " + HurufAkhir);

            Console.WriteLine();

            Console.WriteLine("Contoh TipeData String");
            string NameProject = "LearnFromYoutube";
            string NameProgram = "LearnBasic";
            Console.WriteLine("Nama Project adalah : " + NameProject);
            Console.WriteLine("Nama progam adalah : " + NameProgram);

            Console.WriteLine();

            Console.WriteLine("Contoh TipeData Boolean");
            Boolean a, b;
            a = true;
            b = false;
            Console.WriteLine("Boolean 'a' adalah : " + a);
            Console.WriteLine("Boolean 'b' adalah : " + b);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramHashTable
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            System.Collections.Hashtable objhashtable = new System.Collections.Hashtable();
            //Untuk ADD index dan Value HashTable

            objhashtable.Add("1001", "Chair");
            objhashtable.Add("1002", "Sofa");
            objhashtable.Add("1003", "Carpet");
            objhashtable.Add("1004", 2000);
            objhashtable.Add(1005, "Vas");

            //Untuk DELETE HashTable berdasarkan Value Index-nya
            objhashtable.Remove("1002");

            //Untuk UPDATE HashTable
            objhashtable[1005] = "Table";


            Console.WriteLine(objhashtable[1005]);
        }
    }
}

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

            objhashtable.Add("1001", "Chair");
            objhashtable.Add("1002", "Sofa");
            objhashtable.Add("1003", "Carpet");

            objhashtable.Remove("1002");
            Console.WriteLine(objhashtable);
        }
    }
}

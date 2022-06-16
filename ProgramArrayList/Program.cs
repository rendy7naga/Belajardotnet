using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramArrayList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Collections.ArrayList myValues = new System.Collections.ArrayList();
            myValues.Add("Rendy Sinaga");
            myValues.Add(34);
            myValues.Add(55.5);

            myValues.AddRange(new System.Collections.ArrayList() { "Linggom", 30, 60.5});

            myValues.Insert(0,"Andi");

            foreach (var item in myValues)
            {
                Console.WriteLine(item);
            }
        }
    }
}

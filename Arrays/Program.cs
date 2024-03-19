using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[2];
           
            students[0] = "Burak";
            students[1] = "Hüseyin";

            foreach (var student  in students)
            {
                Console.WriteLine(student);
            }

            string[,] iller = new string[1, 3]
            {
                {"istanbul","Ankara" ,"İzmir"}

            };

            foreach (var il in iller)
            {
                Console.WriteLine(il);
            }


            Console.WriteLine();
            Console.ReadLine();

        }
    }
}

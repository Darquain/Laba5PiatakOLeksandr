using System;
using System.Linq;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Послiдовнiсть А:");
            string D = "5";
            string[] A = { "-73", "-45", "-8", "4", "5", "29", "45" };
            foreach (string el in A)
                Console.Write(el + " ");

            var result = A.Where(x => x.EndsWith(D) && Convert.ToInt32(x) > 0).First();
            Console.WriteLine("\nРезультат: {0}", result);

            Console.ReadLine();
        }
    }
}

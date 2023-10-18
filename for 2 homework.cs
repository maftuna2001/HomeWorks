using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 4;
            int B = 9;
            int N = 0;
            for (int i = 0; A <= B; A++)
            {
                Console.WriteLine(A); N++;
            }
                Console.WriteLine(N);

            Console.ReadKey();
        }
    }
}

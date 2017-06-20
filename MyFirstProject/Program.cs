using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 1, 2, 5, 3,   };
            int[] result = MissingNumber.GetMissingNumber(test);

            Console.WriteLine(String.Join(" ", result));
            Console.Read();
        }
    }
}

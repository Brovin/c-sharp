using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Print(int a) 
            {
	           Console.WriteLine(a);
            }

            static int GetSquare(int a) 
            {
	        return (int)Math.Pow(a, 2);
            }

        static void Main(string[] args)
        {
            Print(GetSquare(42));
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharp
{
    class Program
    {
         static void Main(string[] args)
         {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            int one = String.Compare(a, b);
            int two = String.Compare(a.ToLower(), b.ToLower());
            Console.WriteLine(one);
            Console.WriteLine(two);

            Console.ReadKey();
         }
    }
}
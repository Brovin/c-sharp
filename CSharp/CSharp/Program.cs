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
            int[] arr = {8,5,4};
            Array.Reverse(arr);
            foreach(int a in arr) {
                Console.Write(a);
            }
            Console.ReadKey();
        }
    }
}
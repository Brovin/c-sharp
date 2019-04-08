using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = {1,5,32313,125,124,23,3};
            Console.WriteLine(maxElement(a));
            Console.ReadKey();
        }

        public static int maxElement(int[] numbers) {
            int max = numbers[0];
            foreach(int el in numbers) {
                if(el > max)
                    max = el;
}
            return max;
}
    }
}
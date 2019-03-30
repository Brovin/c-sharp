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
        string[] a = new[] {"Hi", "World", "Woman"};
        foreach(string b in a) {
            Console.WriteLine(b);
        }
        Console.ReadKey();
    }
}
}
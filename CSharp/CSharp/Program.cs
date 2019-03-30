using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class MyClass {
        public void a() {
         Console.WriteLine("Hi");
}
}
    class Program
    {
    static void Main(string[] args)
{
    MyClass a = new MyClass();
    a.a();
    Console.ReadKey();
}
}
}
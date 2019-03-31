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
        public int sum(int a, int b) {
            return a + b;
}
}
    class Program
    {
    static void Main(string[] args)
{
    MyClass a = new MyClass();
    a.a();
    Console.WriteLine(a.sum(1,3));
    Console.ReadKey();
}
}
}
using System;

namespace CSharp
{
    class Test<T1, T2>
    {
        public T1 field1;
        public T2 field2;

        public Test(T1 field1, T2 field2)
        {
            Console.WriteLine($"Число {field1}, Строка {field2}");
        }
    }
}

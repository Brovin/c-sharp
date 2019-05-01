using System;

namespace CSharp
{
    class People : Humans
    {
        public override void say()
        {
            Console.WriteLine("Привет");
        }
        public override void talk()
        {
            Console.WriteLine("Я разговариваю");
        }

        public override void walk()
        {
            Console.WriteLine("Я иду");
        }
    }
}

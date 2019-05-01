using System;

namespace CSharp
{
    abstract class Humans
    {
        public virtual void  say()
        {
            Console.WriteLine("None");
        }

        public abstract void talk();
        public abstract void walk();
    }
}

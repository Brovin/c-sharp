using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Users
    {
        protected string name;
        protected int age;

        public Users(string name, int age) {
            this.name = name;
            this.age = age;
        }

        public void setUser(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual void printAll()
        {
            Console.WriteLine($"Имя: {name}, Возраст {age}");
        }
    }
}

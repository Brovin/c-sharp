using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Admin : Users
    {
        public string role;

        public Admin(string name, int age, string role) : base(name, age)
        {
            this.role = role;
        }

        public override void printAll()
        {
            Console.WriteLine($"Имя: {name}, Возраст {age}, Я {role}");
        }
    }
}

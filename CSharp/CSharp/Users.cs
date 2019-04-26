using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Users
    {
        private string name;
        private int age;
        public Admin admin = new Admin();

        public Users(string name, int age, string role) {
            this.name = name;
            this.age = age;
            admin.role = role;
            Console.WriteLine($"Меня зовут {name}, Мне {age} лет и я {role}");
        }

        public void setUser(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void printAll()
        {
            Console.WriteLine($"Имя: {name}, Возраст {age}");
        }

        public void setAdmin(string role)
        {
            admin.role = role;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharp
{
    class Program
    {
         static void Main(string[] args)
        {
            Users user1 = new Users("Дима", 23);
            user1.printAll();
            Users user2 = new Admin("Леша", 33, "Администратор");
            user2.printAll();
            Car bmw = new Car(180.3f);
            Console.WriteLine($"Скорость {bmw.getSpeed()}");
            Car.Engine engine = new Car.Engine();
            engine.startEngine(true);
            Console.WriteLine(engine.getIsStart());
            Console.ReadKey();
        }
    }
}
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
         delegate void Message();
         delegate int Operation(int x, int y);

         static void Main(string[] args)
        {
            Message mes;

            if(DateTime.Now.Hour < 12){
                mes = GoodMorning;
            } else {
                mes = GoodEvening;
            }

            mes();

            Operation operation = (x, y) => x * y;
            Console.WriteLine(operation(5,5));

            Console.ReadKey();
        }

        private static void GoodMorning(){
            Console.WriteLine("Good Morning");    
        }

        private static void GoodEvening() {
            Console.WriteLine("Good Evening");
        }
    }
}
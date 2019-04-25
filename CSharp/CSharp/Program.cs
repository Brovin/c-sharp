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
            string file_name = @"C:\Users\Spark\Desktop\c-sharp\CSharp\CSharp\text.txt";
            string text = "Hello man";

            StreamWriter sw = File.CreateText(file_name);
            sw.WriteLine(text);
            sw.WriteLine("How are you ?");
            sw.Close();

            StreamReader sr = File.OpenText(file_name);
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();

            Console.ReadKey();
        }
    }
}
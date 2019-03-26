using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string age;
            Console.Write("Whats your name : ");
            name = Console.ReadLine();
            Console.Write("Whats your age : ");
            age = Console.ReadLine();
            Console.WriteLine("Your name is '{0}'", name);
            Console.WriteLine("Your age is '{0}'", age);
        }



    }
}

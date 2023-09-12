using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //call for a method SayHi
            SayHi();

            //call for a method AddNumbers
            AddNumbers();

            //freeze console
            Console.ReadLine();
        }
        static void SayHi() 
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Your name is " + name);

            //freeze console
            Console.ReadLine();
        }
        static void AddNumbers()
        {
            Console.WriteLine("Enter the first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 + num2);
            

        }
    }
}

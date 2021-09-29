using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a number");
            int i = int.Parse(Console.ReadLine());

            if(i < 10)
            {
                Console.WriteLine("Your number was smaller than 10");

            }
            else if (i < 100)
            {
                Console.WriteLine("Your number was smaller than 100");
            }

            else
            {
                Console.WriteLine("Your number was greater than 100");
            }

            Console.ReadLine();


        }

    }
}

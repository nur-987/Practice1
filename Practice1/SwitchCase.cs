using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class SwitchCase
    {
        static void Main(string[] args)
        {
            int students;

            Console.WriteLine("Choose a student number");
            students = int.Parse(Console.ReadLine());
            Console.WriteLine("You chose " + students);

            switch (students)
            {
                case 1:
                    Console.WriteLine("= Dory");
                    break;
                case 2:
                    Console.WriteLine("= Nemo");
                    break;
                case 3:
                    Console.WriteLine("= Sam");
                    break;
                case 4:
                    Console.WriteLine("= Bird");
                    break;
                case 5:
                    Console.WriteLine("= Jerry");
                    break;
                case 6:
                    Console.WriteLine("= Kelly");
                    break;
                case 7:
                    Console.WriteLine("= John");
                    break;

            }

            Console.ReadLine();
        }
    }
}

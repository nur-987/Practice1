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
            #region TRIANGLE

            //for (int x = 6; x >= 1; x--)
            //{
            //    for(int y = 1; y <= x; y++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for(int i = 1; i <= 6; i++)
            //{
            //    for(int k = 1; k <= i; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();
            #endregion

            #region ForEach loop
            //string[] animals = { "cat", "dog", "bird", "horse", "dolphin" };
            
            //foreach (string a in animals)
            //{
            //    Console.WriteLine(a + " is an animal");
            //}

            //Console.ReadLine();
            #endregion

            //For loop
            for(int i =0; i <=10; i++)
            {
                if (i == 7)
                {
                    continue;
                }

                Console.WriteLine(i + "is the current number");

            }

            Console.ReadLine();
        }
    }
}

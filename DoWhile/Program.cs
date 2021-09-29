using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ex 4
            int i = 100; 
            while (i != 0)
            {
                //Console.WriteLine(i);
                i--;

                if(i == 75)
                {
                    continue;
                    
                }
                Console.WriteLine(i);
                //writing (i) must be here else 75 is printed

                if (i == 50)
                {
                    break;
                }

            }
            Console.ReadLine();
            #endregion


            //int i = 0;

            #region Ex.2
            //while (i <= 5)
            //{
            //    Console.WriteLine(i);
            //    Console.WriteLine("Smaller than or equal to 5");
            //    i++;

            //}
            //Console.ReadLine();
            #endregion

            #region Ex.3
            //do
            //{
            //    Console.WriteLine(i);
            //    Console.WriteLine("Smaller than or equal to 5");
            //    i++;
            //}
            //while (i <= 5);
            //Console.ReadLine();
            #endregion

            #region Exercice 1
            //int i = 0;

            //while (i < 10)
            //{
            //    Console.WriteLine("How many laps have you ran?");
            //    i = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Continue Running!");

            //}

            //Console.WriteLine("Congratulations! You are done!");
            //Console.ReadLine();
            #endregion

        }
    }
}

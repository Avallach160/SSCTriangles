using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cbaird_ssc_triangles
{
    class Program
    {
        //write the triangle with given height
        public static void print(int height)
        {
            int space = height - 1;

            for (int i = 1; i <= height; i++)
            {
                //write leading spaces to push the first * over far enough
                for (space = 1; space <= (height - i); space++)
                {
                    Console.Write(" ");
                }

                //writes left half of the triangle
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(starOrSpace(j, i, height));              
                }

                //writes right half of the triangle
                for (int k = (i - 1); k >= 1; k--)
                {
                    Console.Write(starOrSpace(k, i, height));
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        //if first or last character or last row, write a star
        public static string starOrSpace(int count, int i, int height)
        {
            if (count == 1 || i == height)
            {
                return "*";
            }
            else
            {
                return " ";
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Press enter to start.");
            Console.ReadLine();

            //generate a triangle every second for 10 seconds
            for (int i = 1; i <= 10; i++)
            {
                System.Threading.Thread.Sleep(1000);
                string secondsPrint = i.ToString() + " second";
                if (i> 1)
                {
                    secondsPrint += "s";
                }
                Console.WriteLine(secondsPrint);

                print(i);
            }

            Console.WriteLine("Completed. Press enter to exit.");
            Console.ReadLine();
        }
    }
}

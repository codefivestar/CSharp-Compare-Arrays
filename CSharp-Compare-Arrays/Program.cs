using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Compare_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //populate the arrays
            string[] array_A = { "Dog", "Wolf", "Flamingo", "Spider", "?", "7", "Orange", "Android" };
            string[] array_B = { "Fox", "Wolf", "Bear", "7", "Cheese", "Spider", "Cat", "Linux" };

            bool found_switch = false;

            for (int i = 0; i < array_A.Length; i++)
            {
                for (int j = 0; j < array_B.Length; j++)
                {
                    if (array_A[i] == array_B[j])
                    {
                        found_switch = true;
                        Console.WriteLine("array_A element \"" + array_A[i] + "\" was found in array_B");
                    }
                }

                if (found_switch == false)
                {
                    Console.WriteLine("array_A element \"" + array_A[i] + "\" was not found in array_B");
                }

                found_switch = false;
            }

            Console.Write("Press Any Key to exit...");
            Console.ReadKey();
        }
    }
}

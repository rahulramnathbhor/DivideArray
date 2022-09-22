using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideArray
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6 };

            for (int i = 0; i < numbers.Length; i++)
            {

                Console.Write(numbers[i]);  
            }
            Console.WriteLine();    
            Array.Reverse(numbers);
            Console.WriteLine("Reverse Array=");
            foreach (int j in numbers)
            {
                Console.Write(j);

            }
            Console.ReadLine();

        }  

    }
    
}

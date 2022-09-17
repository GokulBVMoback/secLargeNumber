using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secLargeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10]; //declaring array
            Console.WriteLine("Enter the numbers:");
            for (int i = 0; i <10; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine()); //getting input from user for the array
            }
            Array.Sort(num); //Sort the array by smallest to largest
            Array.Reverse(num); //reverse the array
            Console.WriteLine("The Second Largest number of the Array is:" + num[1]);
            Console.WriteLine();
        }
    }
}

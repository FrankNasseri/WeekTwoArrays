using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekTwoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring an array without initializing
            int[] myFirstArray;
            //declaring and initializing a second array
            string[] myStringArray = { "First", "Second", "Third", "Fourth" };
            //declare and initialize a char array with the letters of your last name
            char[] myName = { 'N', 'A', 'S', 'S', 'E', 'R', 'I' };
            //I want my console to print three elements of my array 
            Console.WriteLine(myName[0]);
            Console.WriteLine(myName[3]);
            Console.WriteLine(myName[1]);
        }
    }
}

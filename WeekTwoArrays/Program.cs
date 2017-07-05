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
            ////declaring an array without initializing
            //int[] myFirstArray;
            ////declaring and initializing a second array
            //string[] myStringArray = { "First", "Second", "Third", "Fourth" };
            ////declare and initialize a char array with the letters of your last name
            //char[] myName = { 'N', 'A', 'S', 'S', 'E', 'R', 'I' };
            ////I want my console to print three elements of my array 
            //Console.WriteLine(myName[0]);
            //Console.WriteLine(myName[3]);
            //Console.WriteLine(myName[1]);
            //Create the following arrays and print using the correct index numbers:
            //Array of Top 10 vacations spots
            //string[] vacationSpots = { "Austarlia", "Dubai", "Hawaii", "Iceland", "Cleveland", "Los Angeles", "San Diego", "Aruba", "Jamaica", "Cancun" };
            ////Print the frist and last vacations
            //Console.WriteLine(vacationSpots[0]);
            //Console.WriteLine(vacationSpots[9]);
            //Array of the ages of 3 children you know
            //int[] childAge = { 5, 10, 2 };
            ////all childrens age on one line
            //Console.WriteLine(childAge[0] + " " + childAge[1] + " " + childAge[2]);
            ////print each childs age
            //Console.WriteLine(childAge[0]);
            //Console.WriteLine(childAge[1]);
            //Console.WriteLine(childAge[2]);
            ////Array of GPA's on a 4.0 scale of 8 students - you dont have to print
            //double[] yourGpa = { 1.0, 1.5, 2.0, 2.5, 3.0, 3.2, 3.8, 4.0 };
            //Array of First Letter of 4 of your classmates names who are sitting near you
            //char[] className = { 'J', 'M', 'C', 'F' };
            ////print all four on the same line JMCF
            //Console.WriteLine(className);
            ////print on different lines which prints as JMCF
            //Console.Write(className[0]);
            //Console.Write(className[1]);
            //Console.Write(className[2]);
            //Console.Write(className[3]);
            ////different way of printing on one line, which prints as J, M, C, F
            //Console.WriteLine("\n{0}, {1}, {2}, {3}", className[0], className[1], className[2], className[3]);

            //starting with int array to create space for 21 students
            //dataType[] nameOfArray = new dataType[#ofElements];
            //int[] numberOfSeats = new int[21];
            //string[] studentsInClass = new string[21];

            ////nameOfArray[index] = "Element";
            //studentsInClass[0] = "Jordan";

            //Console.WriteLine("Please eneter in the name of the next student.");
            //studentsInClass[1] = Console.ReadLine();
            //Console.WriteLine("The student in the second seat is {0}.", studentsInClass[1]);
            ////ask user for input
            //Console.WriteLine("Please enter the age of the person in the first seat.");
            ////Create new int array with 21 spots and call it ageOfStudents
            //int[] ageOfStudents = new int[21];
            ////assign the value of the int at the 0 index of ageOfStudents to...
            ////.. the user's input converted into an int
            //ageOfStudents[0] = int.Parse(Console.ReadLine());
            //Console.WriteLine("The age of the student in the first seat is " + ageOfStudents[0]);
            ////Create new string variable and set it equal to the int at the index of 0 ...
            ////and convert it into a string
            //string firstIndex = ageOfStudents[0].ToString();

            ////array for resturants in a mall
            //string[] restaurantsInMall = { "Subway", "Saki", "Dunkin Donuts", "Red Lobster", "Chick Fil-A" };
            //Console.WriteLine(restaurantsInMall.Length);

            ////for review
            ////decalre and not initialize
            //int[] myIntArrayAgain;
            ////declare and initailize an array when i know the elements
            //char[] lettersInFirstName = { 'D', 'A', 'N', 'I', 'E', 'L' };
            ////declare and initialize an array when i dont know the elements but i konw how many
            //string[] variableName = new string[42];

            //To practice using .Length, create a char array of the letters in your middle name..
            ////...and print number of char's to the Console
            //char[] lettersInMiddleName = { 'A', 'r', 'm', 'o', 'n', 'd' };
            //Console.WriteLine(lettersInMiddleName.Length);

            ////Declare and initialize a string array.
            ////using the .Length property, print the SECOND TO LAST element in the array
            //string[] colors = { "Red", "White", "Green", "Blue", "Orange" };
            //int numColor = colors.Length;
            //Console.WriteLine(colors[numColor - 2]);

            //IndexOf is a method used to search an array for specified value and returns...
            //..the index position of the first matching value found.
            //int[] bestYearsEver = { 1985, 1999, 1991, 2000, 1985 };
            //Console.WriteLine(Array.IndexOf(bestYearsEver, 1985));
            ////LastIndexOf is a method used to search an array for a specified value and returns...
            ////..the index position of the last matching value found
            //Console.WriteLine(Array.LastIndexOf(bestYearsEver, 1985));

            ////Reverse Method
            //int[] palindromeNumbers = { 1, 2, 3, 4, 5, 6, 7 };
            //Console.WriteLine(palindromeNumbers[0]);
            //Console.WriteLine(palindromeNumbers[2]);
            //Array.Reverse(palindromeNumbers);
            //Console.WriteLine(palindromeNumbers[0]);
            //Console.WriteLine(palindromeNumbers[2]);

            //Sort Method
            //Will sort numbers in array from lowest to highest
            //Will sort char's and strings in alphabetical order A-Z
            //string[] powerRangers = { "Green", "Yellow", "Pink", "Blue", "Red", "Black", };
            //Console.WriteLine(powerRangers[0]);
            //Array.Sort(powerRangers);
            //Console.WriteLine(powerRangers[0]);

            //Do It practice problems
            ////declare and initialize a string array of first names. choose name to find and print IndexOf
            //string[] firstNames = { "Frank", "Mike", "Jerome", "Steven", "Brian" };
            //Console.WriteLine(Array.IndexOf(firstNames, "Frank"));
            //Create array of lucky numbers. each number should repeat once. choose a lucky number, find and print lastIndexOf
            //int[] luckyNumbers = { 4, 6, 8, 11, 12, 8, 4, 11, 6, 12 };
            //Console.WriteLine(Array.LastIndexOf(luckyNumbers, 11));
            ////create array of alphabet characters. print the first index of the array. now reverse the array and print first indexof
            //char [] letters = { 'A', 'B', 'C', 'E', 'F' };
            //Console.WriteLine(letters[0]);
            //Array.Reverse(letters);
            //Console.WriteLine(letters[0]);
            //create array of students names in random order. order names using sort method. print first and last students name
            string[] studentNames = { "Greg", "Billy", "Frank", "Michael", "Steven", "Marissa" };
            Array.Sort(studentNames);
            Console.WriteLine(studentNames[0] + " " + (studentNames[studentNames.Length - 1]));
            //ask 10 people for favorite number and create array for those numbers. order numbers using sort. print first and last
            int[] favoriteNumber = { 4, 11, 21, 12, 5, 100, 2, 33, 17, 57 };
            Array.Sort(favoriteNumber);
            Console.WriteLine(favoriteNumber[0] + " " + (favoriteNumber[favoriteNumber.Length -1]));







        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4_E3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intialize 2D array to hold values 1-6
            int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 } };
            //Shows user what is happening with array
            Console.WriteLine("Array:");
            //Calls method ArrayOut to output 2D array as is
            ArrayOut(numbers);
            //Spaces out for better visibility
            Console.WriteLine();
            //Variable sum calls SumArray to comb through entire array to add everything in it
            int sum = SumArray(numbers);
            //Outputs sum of array
            Console.WriteLine($"Sum of 2D Array: {sum}");
            //Spaces out for better visibility
            Console.WriteLine();
            //Shows user what is happening with array
            Console.WriteLine("Transposed Array:");
            //Calls method TransArrayOut to output the transposed version of the 2D array
            TransArrayOut(numbers);
            //Pauses program to allow user to view
            Console.ReadLine();
        }
        public static void ArrayOut(int[,] array)
        {
            int rows = array.GetLength(0); //Gets number of rows in array
            int cols = array.GetLength(1); //Gets number of cols in array
            //Nested for loop that first outputs each row then once each row is finished goes to next row until array is all done
            for (int i = 0; i < rows; i++) //Loops through rows first
            {
                for (int j = 0; j < cols; j++) //Loops through cols second
                {
                    Console.Write(array[i, j] + " "); //Prints out element from array on same line
                }
                Console.WriteLine(); //Prints out new line for next row
            }
        }
        public static int SumArray(int[,] array)
        {
            //Set variable sum to zero and returns
            int sum = 0;
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            //Nested for loop that first checks all rows then columns (rows starting at zero and columns at 1)
            for (int i = 0; i < rows; i++) //Sums up rows first
            { 
                for (int j = 0; j < cols; j++) //Sums up columns second
                {
                    sum += array[i, j]; //Adds everything found in array to variable sum
                }
            }
            //Return variable sum to main method
            return sum;
        }
        public static void TransArrayOut(int [,] array)
        {
            int rows = array.GetLength(0); //Gets number of rows in array
            int cols = array.GetLength(1); //Gets number of columns in array
            //Nested for loop that first outputs each column then once each column is finished goes to next column until array is all done
            for (int i = 0; i < cols; i++) //Loops through original cols as rows
            {
                for (int j = 0; j < rows; j++) //Loops through original rows as cols
                {
                    Console.Write(array[j, i] + " "); //Prints out new array by switching rows and columnss
                }
                Console.WriteLine(); //Prints out new line afer each row
            }
        }
       
    }
}

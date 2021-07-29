using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Programs
{
    class FibonacciSeries
    {
        public void PrintFibonacciSeries()
        {
            int firstElement = 0;
            int secondElement = 1;
            int thirdElement , currentPosition ;
            int numberOfElements ;
            Console.WriteLine("Enter the Number of Elements in Fibonacci Series ");
            numberOfElements = Convert.ToInt32(Console.ReadLine());
            Console.Write(firstElement + " " + secondElement + " ");
            for (currentPosition = 2; currentPosition < numberOfElements; currentPosition++)
            {
                thirdElement = firstElement + secondElement;
                Console.Write(thirdElement + " ");
                firstElement = secondElement;
                secondElement = thirdElement;
            }
        }

    }
}

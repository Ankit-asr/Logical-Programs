using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Programs
{
    class ReverseNumber
    {
        public void PrintReverseNumber()
        {
            int number, reverse = 0, remainder;
            Console.Write("Enter the Number ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Original Number is "+number);
            while (number != 0)
            {
                remainder = number % 10;
                reverse = reverse * 10 + remainder;
                number = number/10;
            }
            Console.Write("After Reversing the Number is " + reverse);

        }
    }
}

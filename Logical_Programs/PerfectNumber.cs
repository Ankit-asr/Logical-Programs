using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Programs
{
    class PerfectNumber
    {
        public void CheckPerfectNumber()
        {
            int number , i ;
            int sum = 0;
            Console.WriteLine("Enter the Number");
            number = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i < number; i++)
            {
                if (number % i == 0)
                    sum = sum + i;
            }
            if (sum == number)
                Console.WriteLine(+ number + " is a Perfect Number");
            else
                Console.WriteLine(+ number + " " + "is not a Perfect Number :");


        }
    }
}

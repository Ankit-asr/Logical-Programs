using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Programs
{
    class PrimeNumber
    {
        public void CheckPrimeNumber()
        {
            int number , check = 0;
            Console.WriteLine("Enter the Number");
            number = Convert.ToInt32(Console.ReadLine());
            for(int i=1; i<=number; i++)
            {
                if (number % i == 0)
                    check++;
            }
            if (check == 2)
                Console.WriteLine(+number+" is a Prime Number");
            else
                Console.WriteLine(+number + " is not a Prime Number");
        }
    }
}

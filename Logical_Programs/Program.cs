using System;

namespace Logical_Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("Welcome to Program Menu");
            Console.WriteLine("Press Enter");
            Console.ReadKey();
            Console.WriteLine("Press 1 for Fibonacci Series");
            Console.WriteLine("Press 2 for Perfect Number");
            Console.WriteLine("Press 3 for Prime Number");
            Console.WriteLine("Press 4 for Reverse of a Number");
            Console.WriteLine("Press 5 for Coupon Numbers");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("You selected Fibonacci");
                    FibonacciSeries obj1 = new FibonacciSeries();
                    obj1.PrintFibonacciSeries();
                    break;
                case 2:

                    Console.WriteLine("You selected Perfect Number");
                    PerfectNumber obj2 = new PerfectNumber();
                    obj2.CheckPerfectNumber();
                    break;
                case 3:
                    Console.WriteLine("You selected Prime Number");
                    PrimeNumber obj3 = new PrimeNumber();
                    obj3.CheckPrimeNumber();
                    break;

                case 4:
                    Console.WriteLine("You selected Reverse of a Number");
                    ReverseNumber obj4 = new ReverseNumber();
                    obj4.PrintReverseNumber();
                    break;

                case 5:
                    Console.WriteLine("You selected Coupon Numbers");
                    CouponNumber obj5 = new CouponNumber();
                    obj5.PrintCouponNumbers();
                    break;

                default:
                    Console.WriteLine("You Entered an incorrect choice");
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Programs
{
    class CouponNumber
    {
        public void PrintCouponNumbers()
        {
			int numberOfCoupons;
			int i , numberOfDistinctCoupons = 0 ;
			Console.WriteLine("Enter the number of coupons");
			numberOfCoupons = Convert.ToInt32(Console.ReadLine());
			int[] arr = new int[numberOfCoupons+1];
			for (i = 0; i < numberOfCoupons ; i++)
			{
				Random random = new Random();
				arr[i] = random.Next();
			}
            Console.WriteLine(+numberOfCoupons+ " Coupons which are generated are :");
			for (i = 0; i < numberOfCoupons ; i++)
				Console.WriteLine(+arr[i]+ " ");
			for (i = 0; i < numberOfCoupons; i++)
			{
				if (arr[i] != arr[i+1])
					numberOfDistinctCoupons++;
			}
			Console.WriteLine("The Number of Distinct coupons generated are : " + numberOfDistinctCoupons);

		}
    }
}

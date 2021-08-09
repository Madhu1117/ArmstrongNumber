using System;

namespace ArmstrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 153;
            int r = 0;
            int cube = 0;
            int sum = 0;
            int temp = n;
            for (int i=1; i <= 3; i++)
            {
                r = n % 10;
                cube = r * r * r;
                sum = sum + cube;
                n = n / 10;
            }
            if (sum == temp)
            {
                Console.WriteLine("Given Number is Armstrong Number");
            }
            else
            {
                Console.WriteLine("Given Number is Not an Armstrong Number");
            }
        }
    }
}

using System;

namespace Question_4
{
    class Program
    {
        static void Main(string[] args)

        {
            int sumOfeven = 0; ;
            int sumOfodd = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                    sumOfeven += i;
                else
                    sumOfodd += i;
            }

            Console.WriteLine("The sum of even is : " + sumOfeven);
            Console.WriteLine("The sum of odd is : " + sumOfodd);
        }
    }
}

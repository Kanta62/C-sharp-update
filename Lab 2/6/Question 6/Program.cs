using System;

namespace Question_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            long n = Convert.ToInt32(Console.ReadLine());
            long answer = 1;
            for(int i=1;i<=n;i++)
            {
                answer *= i;  
            }
            Console.WriteLine("The factoria is: " + answer);
        }
      
    }
}

using System;

namespace Question_3
{
    class Program
    {
        static void Main(string[] args)
        {
           for(int i=1;i<=5;i++)
            {
                int j = i;
                int count = 0;
                while(count<5)
                {
                    Console.Write(j);
                    count++;
                    j++;
                }
                Console.WriteLine();
            }
        }
    }
}

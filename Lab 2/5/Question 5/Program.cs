using System;

namespace Question_5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=1;i<=5;i++)
            {
                for(int j=1;j<=5;j++)
                {
                    if (i == j)
                        Console.Write(i);
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }
        }
    }
}

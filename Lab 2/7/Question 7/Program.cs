using System;

namespace Question_7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i <= 5)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    for (int j = 4; j >= i-5; j--)
                    {
                        Console.Write("*");
                    }
                }
                    Console.WriteLine();
                }
            }
        }
    }


using System;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=0;i<4;i++)
            {
                for(int j=0;j<6;j++)
                {
                    if(i%2==0 )
                    {
                       if(j % 2 == 0)
                        Console.Write("X");
                       else
                        Console.Write("0");
                    }
          
                    else
                    {
                        if (j % 2 == 0)
                            Console.Write("0");
                        else
                            Console.Write("X");
                    }

                }
                Console.WriteLine();
            }
        }
    }
}

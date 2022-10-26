using System;
namespace Excercises
{
    class Program
    {
        static void Main(String[] args)
        {
            
                int sum = 0;
                int startTime = Environment.TickCount;
                
                for (int i = 0; i < 10000000; i++)
                {
                    sum++;
                Console.WriteLine(sum);
                }

            }
        }
}

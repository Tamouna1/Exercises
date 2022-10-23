using System;
namespace Excercises
{
    class Program
    {
        static void Main(String[] args)
        {
            //2 Random Numbers

            Random randomNumbers = new Random();

            for (int i = 1; i <=10; i++)
            {
                int rand = randomNumbers.Next(100) + 100;
                Console.WriteLine(rand);
            }
        }
    }
}

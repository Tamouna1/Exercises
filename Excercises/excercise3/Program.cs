using System;
namespace Excercises
{
    class Program
    {
        static void Main(String[] args)
        {
            //3 days of week

            DateTime dt = new DateTime(2022, 10, 23);
            Console.WriteLine("Is Thursday the day of the week for {0:d}?: {1}",
                               dt, dt.DayOfWeek == DayOfWeek.Thursday);
            Console.WriteLine("The day of the week for {0:d} is {1}.", dt, dt.DayOfWeek);
        }
    }
}
    



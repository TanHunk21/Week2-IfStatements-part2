using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Age;
            string UserInput;

            Console.WriteLine("Choose a number between 1-100 ?");
            UserInput = Console.ReadLine();
            Age = Int32.Parse(UserInput);

            if (Age < 50)
            {
                Console.WriteLine($"{Age} < 50");
            }
            else if (Age > 50)
            {
                Console.WriteLine($"{Age} > 50");
            }
            else
            {
                Console.WriteLine($"Nice {Age}");
            }else






        }
    }
}

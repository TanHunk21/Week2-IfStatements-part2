using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Age;
            string UserInput;

            Console.WriteLine("How old are you?");
            UserInput = Console.ReadLine();
            Age = Int32.Parse(UserInput);

            if (Age < 18)
            {
                Console.WriteLine($"you are {Age}, you are too young to get a drivers license.");
            }
            else if (Age > 18)
            {
                Console.WriteLine($"you are {Age}, you are old enough to get a driving license.");
            }
            else
            {
               
            }
        }
    }
}

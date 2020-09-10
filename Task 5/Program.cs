using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserInput;
            Console.WriteLine("What is your favorite animal?");
            UserInput = Console.ReadLine();

            if(UserInput == "cat")
            {
                Console.WriteLine("You are a homebird");
            }else if (UserInput == "dog")
            {
                Console.WriteLine("You are a partygoer.");
            }else
            {
                Console.WriteLine($"You are a {UserInput} friend.");
            }
        }
    }
}

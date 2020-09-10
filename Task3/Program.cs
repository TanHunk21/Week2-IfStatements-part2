using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your first name?");
            string UserInput = Console.ReadLine();
            int Num1 = Int32.Parse(UserInput);
            Console.WriteLine("What is your second name?");
            UserInput = Console.ReadLine();
            int Num2 = Int32.Parse(UserInput);

            if (Num1 == Num2)
            {
                Console.WriteLine("The number you provided are equal");
            }    
            
            {
                Console.WriteLine("The number you provided are not equal");
            }
            

                





                
            
            









        }
    }
}

using System;

namespace Q11
{
    class Program
    {
        static void Main(string[] args)
        {
             int attempts = 0;
            string myPassword;

            attempts++;
            Console.WriteLine("Attempt {0} - Enter Password : ", attempts);
            myPassword = Console.ReadLine();

            while(myPassword !="What"&& attempts <5)
            {
                //If wrong password is entered
                Console.WriteLine("Sorry-Wrong Password");

                attempts++;
                Console.WriteLine("Attempt {0} - Enter Password :", attempts);
                myPassword = Console.ReadLine();

            }

            //Password is correct to get to this stage
            if (myPassword == "What")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("All attempts used -- call the Authorities");
            }
            
        }
    }
}

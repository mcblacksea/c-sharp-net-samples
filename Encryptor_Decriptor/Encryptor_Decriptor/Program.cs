using System;

namespace Encryptor_Decriptor
{
    class Program
    {
        static void Main(string[] args)
        {

            string password_before = "", password_after = "", method = "", exit_str ="";

            while (true) // Loop indefinitely
            {
                Console.WriteLine();

                Console.WriteLine("Enter your password:");

                password_before = Console.ReadLine(); // Get password string from user

                Console.WriteLine("Select the method: \r\nEncrypt, press 'e' / or Decrypt, press 'd':");
                method = Console.ReadLine(); // Get method

                if (method == "e") // Check string
                {
                    password_after = Executor.Encrypt(password_before);
                }
                else if (method == "d")
                {
                    password_after = Executor.Decrypt(password_before);
                }
                else
                {
                    Console.WriteLine("The wrong key was entered...\r\nPlease try again...\r\n");
                    continue;
                }

                Console.WriteLine(new string('-', 50));

                Console.WriteLine("Your password is: \r\n{0}", password_after);

                Console.WriteLine(new string('-', 50));

                Console.WriteLine();

                Console.WriteLine("To exit press '{0}' / To continue press any other key", "e");

                exit_str = Console.ReadLine();

                if (exit_str == "e")
                {
                    break;
                }

            }
        }
    }
}

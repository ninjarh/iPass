using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPASS
{
    internal class MainMethods
    {

        public void Clear()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\tPassword Generator\n");
            Console.ForegroundColor = ConsoleColor.Green;
        }

        public int mainOptions()
        {
            int mainoption;

            Clear();

            Console.Write("Create New Password 1\nExit 0\n" +
                "\nOption: ");

            mainoption = int.Parse(Console.ReadLine());

            return mainoption;
        }

        public int getLen()
        {
            int len;
            while (true)
            {

                Console.Write("Enter length of password: ");
                len = int.Parse(Console.ReadLine());

                if (len >= 4 && len <= 16)
                {
                    break;
                }
                else
                {
                    Clear();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("The password must contain a minimum of 4 characters and a maximum of 16!\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
            }

            return len;
        }

        public int getPassOption()
        {
            int option;
            while (true)
            {
                Console.Write("Only Number " +
                       "1\nOnly Letters 2\nBoth mixed (recommended) 3" +
                       "\n\nEnter type of password: ");
                option = int.Parse(Console.ReadLine());

                if (option >= 1 && option <= 3)
                {
                    break;
                }
                else
                {
                    Clear();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Not selected correctly! Try Again!\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
            }
            return option;
        }

        //create new password
        public void newPassword()
        {
            Clear();

            int len = getLen();
            Clear();
            int option = getPassOption();

            RandomPass rpass = new RandomPass();

            switch (option)
            {
                case 1: rpass.RandomPasswordOnlyNumbers(len); break;
                case 2: rpass.RandomPasswordOnlyLetters(len); break;
                case 3: rpass.RandomPasswordMixed(len); break;
                default: Clear(); Console.WriteLine("Choose the right option!\n"); break;
            }

            Clear();
            Console.WriteLine("Password Created!");
            Console.WriteLine($"Your password: {rpass.randomPassword}");

            info();

        }

        public void info()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\n\nMade by Rahil Babashov 2023 ©");

        }
    }
}

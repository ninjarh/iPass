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

            Console.Write("Yeni Sifre yaratmaq ucun 1\nCixmaq ucun 0\n" +
                "\nSeciminiz: ");

            mainoption = int.Parse(Console.ReadLine());

            return mainoption;
        }

        public int getLen()
        {
            int len;
            while (true)
            {

                Console.Write("Sifre uzunlugunu daxil edin: ");
                len = int.Parse(Console.ReadLine());

                if (len >= 4 && len <= 15)
                {
                    break;
                }
                else
                {
                    Clear();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Sifre minimum 4, maksimum 15 simvoldan ibaret ola biler!\n");
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
                Console.Write("Yalniz reqemli sifre uchun " +
                       "1\nYalniz herfli sifre uchun 2\nQarisiq sifre (Tovsiye olunan) uchun 3" +
                       "\n\nSifrenin formasini secin: ");
                option = int.Parse(Console.ReadLine());

                if (option >= 1 && option <= 3)
                {
                    break;
                }
                else
                {
                    Clear();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Duzgun sechim edilmedi! Yeniden yoxla!\n");
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
                default: Clear(); Console.WriteLine("Secimi duzgun daxil edin!\n"); break;
            }

            Clear();
            Console.WriteLine("Sifre Yaradildi!");
            Console.WriteLine($"Sizin Sifreniz: {rpass.randomPassword}");

            info();

        }

        public void info()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\n\nMade by Rahil Babashov 2023 ©");

        }
    }
}

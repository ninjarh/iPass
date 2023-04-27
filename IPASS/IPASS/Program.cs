using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPASS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean check = true;
            MainMethods call = new MainMethods();

            while (check)
            {
                int mainoption; 

                mainoption = call.mainOptions();

                switch (mainoption)
                {
                    case 0:

                        call.Clear();
                        Console.WriteLine("Thank you for trusting your passwords to us!");
                        call.info(); check = false; break;

                    case 1: call.newPassword(); break;

                    default: Console.WriteLine("Not selected correctly! Try Again!"); break;
                }  

                Console.ReadLine();
            }
                 
        }

    }
}

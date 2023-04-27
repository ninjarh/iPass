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
                        Console.WriteLine("Sifrelerinizi bize emanet etdiyiniz uchun teshekkurler!");
                        call.info(); check = false; break;

                    case 1: call.newPassword(); break;

                    default: Console.WriteLine("Duzgun sechim edilmedi! Yeniden yoxla!"); break;
                }  

                Console.ReadLine();
            }
                 
        }

    }
}

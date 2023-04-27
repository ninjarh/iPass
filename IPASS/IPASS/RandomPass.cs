using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPass
{
    internal class RandomPass
    {
        private string password;

        PasswordResources src = new PasswordResources();
        Random rand = new Random();

        public void RandomPasswordOnlyNumbers(int len)
        {

            for (int i = 0; i < len; i++)
            {
                password += src.Alphanumbers[rand.Next(0, src.Alphanumbers.Length)];
            }

        }

        public void RandomPasswordOnlyLetters(int len)
        {

            for (int i = 0; i < len; i++)
            {
                password += src.Alphaletters[rand.Next(0, src.Alphaletters.Length)];
            }

        }

        public void RandomPasswordMixed(int len)
        {

            for (int i = 0; i < len; i++)
            {
                password += src.Alphamixed[rand.Next(0, src.Alphamixed.Length)];
            }

        }

        public string randomPassword
        {
            get { return password; }
            set { password = value; }
        }

    }
}

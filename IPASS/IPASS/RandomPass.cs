using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPASS
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
            int checker=0;
            for (int i = 0; i < len; i++)
            {
                password += src.Alphamixed[rand.Next(0, src.Alphamixed.Length)];

                for(int j  = 0; j<10; j++)
                { 
                   string k = j.ToString();
                    if(password.Contains(k))
                    {
                        checker++;
                        
                    }
                }
            }

            if(checker == 0)
            {
                password = "";
                RandomPasswordMixed(len);
            }

        }

        public string randomPassword
        {
            get { return password; }
            set { password = value; }
        }

    }
}

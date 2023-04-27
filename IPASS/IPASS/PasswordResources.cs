using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPass
{
    internal class PasswordResources
    {
        private char[] alphanumbers = "1234567890".ToCharArray();
        private char[] alphaletters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuwxyz".ToCharArray();
        private char[] alphamixed = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuwxyz1234567890".ToCharArray();

        public char[] Alphanumbers
        {
            get { return alphanumbers; }
            set { alphanumbers = value; }
        }

        public char[] Alphaletters
        {
            get { return alphaletters; }
            set { alphaletters = value; }
        }

        public char[] Alphamixed
        {
            get { return alphamixed; }
            set { alphamixed = value; }

        }

    }
}

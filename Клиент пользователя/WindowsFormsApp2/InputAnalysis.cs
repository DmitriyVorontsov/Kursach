using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal static class InputAnalysis
    {
        public static bool CheckLogin(string login)
        {
            if (login.Length != 12)
                return false;

            foreach (char c in login)
            {
                if (!(c >= '0' && c <= '9'))
                    return false;
            }

            return true;
        }

        public static bool CheckPassword(string password)
        {

            foreach(char c in password)
            {
                if (c == ' ')
                {
                    return false;
                }
            }

            return true;
        }
    }
}

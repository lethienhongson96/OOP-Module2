using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class TestShape
    {
        public static void Main()
        {
            string email = "lethienhongson@gmai.com";
            Console.WriteLine(IsValidEmail(email));
        }

        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}

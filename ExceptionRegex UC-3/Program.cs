using System;
using System.Text.RegularExpressions;

namespace ExceptionRegex_UC_3
{
   public class Program
    {
       public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Your EMail Like (Eg:abc01@gmail.com)");
                string email = Console.ReadLine();
                if (Regex.Match(email, "^[0-9a-z]{1,}[@][a-z]{5}[.][a-z]{3}$").Success)
                {
                    Console.WriteLine("EMail is Valid");
                }
                else
                {
                    Console.WriteLine("EMail is Not Valid");
                }
            }
            catch
            {
            }
        }
    }
}

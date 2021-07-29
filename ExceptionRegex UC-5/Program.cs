using System;
using System.Text.RegularExpressions;

namespace ExceptionRegex_UC_5
{
   public class Program
    {
       public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Your Password Should Have Minimum 8 Characters");
                string rule1 = Console.ReadLine();
                if (Regex.Match(rule1, "^[a-z]{8,}$").Success)
                {
                    Console.WriteLine("Password is Valid");
                }
                else
                {
                    Console.WriteLine("Password is Not Valid");
                }
            }
            catch
            {
            }
        }
    }
}

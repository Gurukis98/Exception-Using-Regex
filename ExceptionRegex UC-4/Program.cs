using System;
using System.Text.RegularExpressions;

namespace ExceptionRegex_UC_4
{
   public class Program
    {
       public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Your Mobilenumber Like (Eg:91 9919819801)");
                string mobileNumber = Console.ReadLine();
                if (Regex.Match(mobileNumber, "^[0-9]{2} [0-9]{10}$").Success)
                {
                    Console.WriteLine("Mobilenumber is Valid");
                }
                else
                {
                    Console.WriteLine("Mobilenumber is Not Valid ");
                }
            }
            catch
            {
            }
        }
    }
}

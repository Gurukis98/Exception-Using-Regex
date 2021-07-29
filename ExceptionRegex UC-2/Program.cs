using System;
using System.Text.RegularExpressions;

namespace ExceptionRegex_UC_2
{
   public class Program
    {
       public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Your Lastname Starts with Capital and it Have Minimum 3 Character");
                string lastName = Console.ReadLine();
                if (Regex.Match(lastName, "^[A-Z][A-Za-z]{2,}$").Success)
                {
                    Console.WriteLine("Lastname is Valid");
                }
                else
                {
                    Console.WriteLine("Lastname is Not Valid ");
                }
            }
            catch
            {
            }
        }
    }
}

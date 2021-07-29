using System;
using System.Text.RegularExpressions;

namespace ExceptionRegex_UC_1
{
    public class Program
    {
       public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Your Firstname Starts with Capital and it Have Minimum 3 Character");
                string firstName = Console.ReadLine();
                if (Regex.Match(firstName, "^[A-Z][A-Za-z]{2,}$").Success)
                {
                    Console.WriteLine("Firstname is Valid");
                }
                else
                {
                    Console.WriteLine("Firstname is Not Valid ");
                }
            }
            catch
            {
            }
        }
    }
}

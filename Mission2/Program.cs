using System;

namespace Mission2
{
    public class Program
    {
        //Start of program
      //  public /*accessible outside of program*/static /*this applies to this class itself */ void /* return type (can be string, inte etc) */ Main /*name of method*/(string[] /*what the method accepts*/ args/*name of the variable the method accepts*/)
        public static void Main (string[] args)
        {
            PrintIt ps;
            string ?userName = "";
            string language = "";

            Console.WriteLine("What language do you speak: ");
            language = Console.ReadLine();
            Console.WriteLine("Please enter your name: ");
            userName = Console.ReadLine();

            ps = new PrintIt(language);

            ps.PrintName(userName);
        }
        
    }
}

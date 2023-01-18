using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    public class PrintIt
    {
        private string language = "";
        public PrintIt(string temp)
        {
            language = temp;
        }
        public void PrintName(string name)
        {
            if (language == "EN")
            {
                Console.WriteLine("Hello " + name);
            }
            else
            {
                Console.WriteLine("Privet " + name);
            }
        }
    }
}

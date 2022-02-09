using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace github
{
    class Program
    {
        static void joke()
        { 
            Console.WriteLine("knock knock");
            string answear = Console.ReadLine();
            if (answear=="Who's there?")
            {
                Console.WriteLine("Joe");
                string answear2 = Console.ReadLine();
                if (answear2 == "Who's Joe?")
                {
                    Console.WriteLine("Joe Mama XDDDD");
                }
                else
                {
                    joke();
                }
            }
            else
            {
                joke();
            }
        }
        static void Main(string[] args)
        {
            joke();
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        public static void IntCheckerForString(string x)
        {
            try
            {
                int i = Int32.Parse(x);
                Console.WriteLine(i);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("String to Int: ");
            String a = Console.ReadLine();
            IntCheckerForString(a);
            Console.ReadKey();
        }
    }
}

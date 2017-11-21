using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Example3
{
    class Program
    {


        public static void Main(string[] args)

        {

            English E = new English();
            Console.Write("Number of words in String " + E.Words());
            
            Console.Write("The number of occurrences is " + E.find("I am in London and I am in QA", "am"));

            Console.Read();
        }
    }

}

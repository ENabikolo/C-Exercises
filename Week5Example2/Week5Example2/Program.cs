using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Example2
{
    class Results
    {
        private int phy, che, mat;

        public int Physics
        {
            set
            {
                if (value >= 0 & value <= 150)
                    phy = value;
                else {
                    phy = -1;
                    Console.Write("Invalid Physics Mark");
                }
            }
            get {
                return phy;

            }
        }
        public int Chemistry
        {
            set {
                if (value >= 0 & value <= 150)
                    che = value;
                else {
                    che = -1;
                    Console.Write("Invalid Chemistry Mark");
                }
            }
            get
            {
                return che;

            }
        }
        public int Maths
        {
            set
            {
                if (value >= 0 & value <= 150)
                    mat = value;
                else
                {
                    mat = -1;
                    Console.Write("Invalid Maths Mark");
                }
            }
            get
            {
                return mat;

            }
        }
        public void showResults()
        {
            if (phy==-1 || che==-1 || mat==-1)
            {
                Console.Write("SOme invalid marks Entered");

            } else
            {
                int Total;
                float Per;
                Total = phy + che + mat;
                Per = ((float)Total * 100 / 450);

                Console.Write("Total marks: " + Total + "\n");
                Console.Write("Percentage: " + Per + "\n");
            }
        }
    }

    class MM { 
        static void Main(string[] args)
        {
            Results Peter;
            Peter = new Results();

            Peter.Physics = 59;
            //Console.Write(5 / 2);
            Peter.showResults();
            Console.Read();
        }
    }
    }

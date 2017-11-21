using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Example1
{
    class Results
    {
        private int phy, che, mat;
        //int passMark = 60;
        public int Physics {
            set{
                if (value >= 0 & value <= 150)
                    phy = value;
                else{
                    phy = -1;
                    Console.Write("Invalid Physics Mark");
                }
            }
            get{
                return phy;
            }
        }
        public void Chemistry(int B)
        {
            if (B >= 0 & B <= 150)
            {
                che = B;
            }
            else
            {
                Console.Write("Invalid Chemistry Marks");
            }

        }
        public void Maths(int C)
        {
            if (C >= 0 & C <= 150)
            {
                mat = C;
            }
            else
            {
                Console.Write("Invalid Maths Marks");
            }

        }

        public void showResults()
        {
            if (phy >= 150 || che >= 150 || mat >= 150)
            {
                Console.Write("No Results Available");
                /*
                    if(passMark < 90)
                   if (phy < 60 & che >= 60 & mat >= 60)
                   { Console.Write("Retake the exam");
                   } else if
                     (phy < 60 & che < 60 & mat >= 60)
                   { Console.Write("Repeat the course");
                   }else if{ Console.Write("Go Home!");
                      //if ((phy <60  (che <0 & che >= 150) || (mat < 0 & mat >= 150))
                      */
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

            public static void Main(string[] args) {
                Results Peter, Smith;
                Peter = new Results();
                Smith = new Results();

                Peter.phy = 950;
                Peter.che = 50;
                Peter.mat = 70;

                Smith.phy = 5146;
                Smith.che = 5700;
                Smith.mat = 1070;
                //Console.Write(5 / 2);
                Peter.showResults();
                Smith.showResults();
                Console.Read();
            }
        }
    }



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Example3
{

    public class English
    {

        public int Words()
        {
            string y = "I am in QA and I am going to London";
            //String wordCountStr ="";
            //int count = y.Split(' ').Length

            return y.Split(' ').Length;
        }


        public int find(string message, string findWhat) //within the message, find a particular substring and count how many times it happens. 
        {
            int count = 0;

            for (int i = 0; i < message.Length; i++) {
                message.Substring(i, findWhat.Length);
                if (message.Substring(i, findWhat.Length).Equals(findWhat)) {
                    count++;
                }

            }
            return count;
        }

        /*

        public int verticalSentence(string x) //go to the next line after each word. Use \n or after the spaces, create a new line. 
        {
            x = "How are you doing today?"; 

            for (x=0; x)
        }


        public int ReverseSentence(string message, int length)
        {
            for(int )*/

    }
}


     

                
          
       
  

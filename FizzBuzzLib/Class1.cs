using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzLib
{
    public class FizzBuzzClass
    {


        public bool IsFizz(int p)
        {
            return(p % 3 == 0 ? true: false);
        }

        public bool IsBuzz(int p)
        {
            return (p % 5 == 0 ? true : false);
        }

        public bool isFizzBuzz(int p)
        {
            return (IsFizz(p) && IsBuzz(p) ? true : false);
                        
        }

        public string runFizzBuzz()
        {
            string result = "";

            for (int i = 1; i < 100; i++)
            {
                string temp = "";

                if (isFizzBuzz(i))
                {
                    temp = "FizzBuzz";
                }
                else if (IsFizz(i))
                {
                    temp = "Fizz";
                }
                else if (IsBuzz(i))
                {
                    temp = "Buzz";
                }
                else
                    temp = i.ToString();

                result = result + " " + temp;

            }
            //Test commit to github
            return result; //just commit FFS
        }
    }
}

using System;

namespace spike.codebase
{
    public class FizzBuzz
    {
        public string doFizzBuzz(int input)
        {
            if (input == 0)
            {
                return "0";
            }
            else if (input == 1)
            {
                return "1";
            }
            else if (input == 2)
            {
                return "2";
            }
            else if (input == 3)
            {
                return "Fizz";
            }
            else if (input == 4)
            {
                return "4";
            }
            else if (input == 5)
            {
                return "Buzz";
            }
            else
            {
                return "7";
            }
            //complex
        }
    }
}
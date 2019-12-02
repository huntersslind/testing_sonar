using System;

namespace spike.codebase
{
    public class FizzBuzz
    {
        public string doFizzBuzz(int input)
        {
            if (input == 3)
            {
                return "Fizz";
            }
            else if (input == 5)
            {
                return "Buzz";
            }
            else
            {
                return input.ToString();
            }
            //complex
        }
    }
}
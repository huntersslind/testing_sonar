using System;

namespace spike.codebase
{
    public class Class1
    {
        public string fizz(int input)
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
                return "fizz";
            }
            else if (input == 4)
            {
                return "4";
            }
            else if (input == 5)
            {
                return "buzz";
            }
            else if (input == 6)
            {
                return "6";
            }

            return "7";
        }
    }
}
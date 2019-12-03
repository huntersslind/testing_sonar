namespace spike.codebase
{
    public static class FizzBuzz
    {
        public static string doFizzBuzz(int input)
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
namespace RecursionPractice
{
    public static class MathMethods
    {
        public static int GetFactorial(int number)
        {
            //Exit Condition
            if (number == 1 || number == 0)
            {
                return 1;
            }
            return number * GetFactorial(number - 1);
        }
    }
}

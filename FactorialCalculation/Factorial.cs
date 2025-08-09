namespace FactorialCalculation
{
    class Factorial
    {
        public int num;
        public void number()
        {
            if (num < 0)
            {
                Console.WriteLine("Error:Pleasse enter a non negative number");
            }
            else
            {
                int factorial = 1;
                for (int i = 1; i <= num; i++)
                {
                    factorial = factorial * i;
                }
                Console.WriteLine($"Factorial of {num} is {factorial}");
            }
        }
    }
}
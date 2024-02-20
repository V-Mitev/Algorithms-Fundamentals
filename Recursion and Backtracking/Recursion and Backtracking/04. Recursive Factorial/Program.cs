namespace _04._Recursive_Factorial
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine()!);

            Console.WriteLine(CalculateFactorialRecursivley(number));
        }

        private static int CalculateFactorialRecursivley(int number)
        {
            if (number == 0)
            {
                return 1;
            }

            return number * CalculateFactorialRecursivley(number - 1);
        }
    }
}

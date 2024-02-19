namespace _01._Recursive_Array_Sum
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine()!
                .Split()
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(CalculateArraySumRecursivley(input, 0));
        }

        private static int CalculateArraySumRecursivley(int[] input, int index)
        {
            if (index == input.Length - 1)
            {
                return input[index];
            }

            return input[index] + CalculateArraySumRecursivley(input, index + 1);
        }
    }
}

namespace _03._Generating_Vectors
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine()!);

            int[] array = new int[n];

            PrintVecotr(array, 0);
        }

        private static void PrintVecotr(int[] array, int index)
        {
            if (index == array.Length)
            {
                Console.WriteLine(string.Join(string.Empty, array));

                return;
            }

            for (int i = 0; i < 2; i++)
            {
                array[index] = i;

                PrintVecotr(array, index + 1);
            }
        }
    }
}

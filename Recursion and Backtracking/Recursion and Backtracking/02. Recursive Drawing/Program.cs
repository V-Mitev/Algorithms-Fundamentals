namespace _02._Recursive_Drawing
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine()!);

            DrawRecursivley(n);
        }

        private static void DrawRecursivley(int n)
        {
            if (n == 0)
            {
                return;
            }

            Console.WriteLine(new string('*', n));

            DrawRecursivley(n - 1);

            Console.WriteLine(new string('#', n));

            n++;
        }
    }
}

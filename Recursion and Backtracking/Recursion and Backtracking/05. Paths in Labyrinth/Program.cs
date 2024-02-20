namespace _05._Paths_in_Labyrinth
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            int row = int.Parse(Console.ReadLine()!);
            int col = int.Parse(Console.ReadLine()!);

            char[,] matrix = new char[row, col];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var values = Console.ReadLine()!;

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = values[j];
                }
            }

            var directions = new List<string>();

            FindPathsRecursivley(matrix, 0, 0, string.Empty, directions);
        }

        private static void FindPathsRecursivley(char[,] matrix, int row, int col, string direction, List<string> directions)
        {
            if (row < 0 || row >= matrix.GetLength(0) || col < 0 || col >= matrix.GetLength(1))
            {
                return;
            }

            if (matrix[row, col] == '*' || matrix[row, col] == 'v')
            {
                return;
            }

            directions.Add(direction);

            if (matrix[row, col] == 'e')
            {
                Console.WriteLine(string.Join(string.Empty, directions));
                directions.RemoveAt(directions.Count - 1);
                return;
            }

            matrix[row, col] = 'v';

            FindPathsRecursivley(matrix, row + 1, col, "D", directions); //DOWN
            FindPathsRecursivley(matrix, row, col + 1, "R", directions); //RIGHT
            FindPathsRecursivley(matrix, row - 1, col, "U", directions); //UP
            FindPathsRecursivley(matrix, row, col - 1, "L", directions); //LEFT

            matrix[row, col] = '-';
            directions.RemoveAt(directions.Count - 1);
        }
    }
}

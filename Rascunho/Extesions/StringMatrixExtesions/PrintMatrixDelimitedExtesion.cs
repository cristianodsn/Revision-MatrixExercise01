﻿namespace Rascunho.Extesions.StringMatrixExtesions
{
    internal static class PrintMatrixDelimitedExtension
    {
        public static void PrintLimitedDiagonalMConsole(this string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        TurnColor();
                        Console.Write(matrix[i, j]);
                    }
                    else
                    {
                        Console.Write(matrix[i, j]);
                    }
                    Console.ResetColor();
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        private static void TurnColor()
        {
            ConsoleColor delimitedColor = ConsoleColor.DarkMagenta;

            Console.BackgroundColor = delimitedColor;
        }

        public static void PrintIntMatrix(this int[,] mat)
        {
            string[,] matString = PrintMatrix.GenerateStringMatrix(mat);

            for (int i = 0; i < matString.GetLength(0); i++)
            {
                for (int j = 0; j < matString.GetLength(1); j++)
                {
                    Console.Write(matString[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

    }
}

namespace Rascunho
{
    internal static class PrintMatrix
    {

        public static string[,] GenerateStringMatrix(int[,] mat)
        {
            int largestNumber = GetLargestLengthNumber(mat);
            string[,] stringMat = ConvertMatrixToString(mat);

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    int number = int.Parse(stringMat[i, j]);
                    stringMat[i, j] = EqualizingPlace(number, largestNumber, '0');
                }
            }
            return stringMat;
        }
        private static int GetLargestLengthNumber(int[,] mat)
        {
            int largestNumber = 0;

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (mat[i, j].ToString().Length > largestNumber) largestNumber = mat[i, j].ToString().Length;
                }
            }

            return largestNumber;
        }

        private static string[,] ConvertMatrixToString(int[,] mat)
        {
            string[,] sMat = new string[mat.GetLength(0), mat.GetLength(1)];

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    sMat[i, j] = mat[i, j].ToString();
                }
            }

            return sMat;
        }

        private static string EqualizingPlace(int number, int quantity, char character)
        {
            try
            {
                if (number.ToString().Length > quantity)
                {
                    throw new Exception("The number connot be greater than quantity value");
                }
                return new string(character, quantity - number.ToString().Length) + number.ToString();
            }
            catch (Exception ex)
            {
                return (ex.Message);
            }
        }

    }
}

using Rascunho;

Console.Write("Inform the value to start a new matrix (NxN): ");
int quantity = int.Parse(Console.ReadLine());
int[,] mat = new int[quantity, quantity];
Console.Clear();
try
{
    for (int i = 0; i < quantity; i++)
    {
        
        
        for (int j = 0; j < quantity; j++)
        {
            Console.WriteLine("Matrix Information:");
            mat.PrintIntMatrix();
            Console.WriteLine();
            Console.WriteLine("Enter the velues of the matrix:");
            Console.WriteLine($"Row {i + 1}, Column {j + 1}");
            mat[i, j] = int.Parse(Console.ReadLine());
            Console.Clear();          

        }
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

string[,] stringMat = PrintMatrix.GenerateStringMatrix(mat);
stringMat.PrintLimitedDiagonalMConsole();

Console.ReadKey();


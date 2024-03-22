using Rascunho;
using Rascunho.Extesions.StringMatrixExtesions;

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
Console.WriteLine("Main Diagonal:");
Console.WriteLine();
string[,] stringMat = PrintMatrix.GenerateStringMatrix(mat);
stringMat.PrintLimitedDiagonalMConsole();

Console.WriteLine();
Console.Write("Positive Numbers: ");

Console.WriteLine(string.Join(", ", mat.Cast<int>().Where(n => n >= 0)));

Console.Write("Negative Numbers: " + string.Join(", ",mat.Cast<int>().Where(n => n < 0)));
Console.WriteLine();

Console.ReadKey();


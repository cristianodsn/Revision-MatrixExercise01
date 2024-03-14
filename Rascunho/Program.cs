using Rascunho;

Console.Write("Inform the value to start a new matrix (NxN): ");
int quantity = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the velues of the matrix:");
int[,] mat = new int[quantity, quantity];

try
{
    for (int i = 0; i < quantity; i++)
    {
        for (int j = 0; j < quantity; j++)
        {
            Console.WriteLine($"Row {i + 1}, Column {j + 1}");
            mat[i, j] = int.Parse(Console.ReadLine());
        }
    }
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

string[,] stringMat= PrintMatrix.GenerateStringMatrix(mat);
for (int i = 0; i < stringMat.GetLength(0); i++)
{
    for (int j = 0; j < stringMat.GetLength(1); j++)
    {
        Console.WriteLine(" " + stringMat[i, j]);
    }
    Console.WriteLine();
}

Console.ReadKey();


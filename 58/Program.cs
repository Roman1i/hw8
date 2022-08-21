Console.WriteLine("Размер матрицы:");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];
int[,] matrix2 = new int[m, n];
int[,] matrix3 = new int[m, n];

for (int i = 0; i < m; i++)
{
    Console.WriteLine();
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(1,10);
        Console.Write(matrix[i, j] + " ");
    }
}
Console.WriteLine();

for (int i = 0; i < m; i++)
{
    Console.WriteLine();
    for (int j = 0; j < n; j++)
    {
        matrix2[i, j] = new Random().Next(1,10);
        Console.Write(matrix2[i, j] + " ");
    }
}
Console.WriteLine();

for (int i = 0; i < m; i++)
{
    Console.WriteLine();
    for (int j = 0; j < n; j++)
    {
        matrix3[i, j] = matrix[i, j] * matrix2[i, j];
        Console.Write(matrix3[i, j] + " ");
    }
}









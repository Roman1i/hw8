int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];

for (int i = 0; i < m; i++)
{
    Console.WriteLine();
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(1, 10);
        Console.Write(matrix[i, j] + " ");
    }
}

int tmp;
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n - 1; j++)
    {
        if (matrix[i, j] > matrix[i, j + 1])
        {
            tmp = matrix[i, j];
            matrix[i, j] = matrix[i, j + 1];
            matrix[i, j + 1] = tmp;
            j = - 1;
        }
    }
}

Console.WriteLine();

for (int i = 0; i < m; i++)
{
    Console.WriteLine();
    for (int j = 0; j < n; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
}
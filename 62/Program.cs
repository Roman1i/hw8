Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, n];
int x = 0;
int y = 0;
int size = n * n;

for (int i = 1; i <= size; i++)
{
    matrix[x, y] = i;
    if (x == 0 || y == 0 || x == n - 1 || y == n - 1)
    {
        if (y + 1 != n && x == 0) y++;
        else if (x + 1 != n && y == n -1) x++;
        else if (y != 0 && x == n - 1) y--;
        else if (matrix[x - 1, y] == 0) x--;
        else y++;
    }
    else
    {
        if (matrix[x, y + 1] == 0) y++;
        else if (matrix[x + 1, y] == 0) x++;
        else if (matrix[x, y - 1] == 0) y--;
        else x--;
    } 
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    Console.WriteLine();
    for (int j = 0; j < matrix.GetLength(1); j++)
    Console.Write(matrix[i, j] + "\t");
}

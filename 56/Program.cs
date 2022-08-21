int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n]; 
int[] arr = new int[m];

for (int i = 0; i < m; i++)
{
    Console.WriteLine();
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(1, 10);
        Console.Write(matrix[i, j] + " ");
        arr[i] += matrix[i, j];
    }
}

int min = arr[0];
int ind = 0;

for (int i = 0; i < m; i++)
{
    if (arr[i] < min)
    {
        min = arr[i];
        ind = i;
    }
}

Console.WriteLine();
Console.WriteLine(ind);

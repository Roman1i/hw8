int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int z = Convert.ToInt32(Console.ReadLine());
int[,,] cube = new int[x, y, z];

for (int i = 0; i < cube.GetLength(0); i++)
{
    Console.WriteLine();
    for (int j = 0; j < cube.GetLength(1); j++)
    {
        Console.WriteLine();
        for (int k = 0; k < cube.GetLength(2); k++)
        {
            cube[i, j, k] = new Random().Next(10, 100);
            Console.Write(cube[i, j, k] + " ");

        }
    }
}

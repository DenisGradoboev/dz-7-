// Задайте двумерный массив (вручную) размером m×n, заполненный случайными вещественными числами.
Console.WriteLine("Ведите числа m и n");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
double [,] array2d = new double[m, n];
Random random = new Random();
for (int i=0; i<m;i++)
{
    for (int j=0; j<n; j++)
    {
        array2d[i,j]=random.NextDouble ()*9;
        Console.Write(array2d[i,j]+" ");
    }
Console.WriteLine();
}
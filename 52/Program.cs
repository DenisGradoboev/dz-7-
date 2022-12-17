// Задайте двумерный массив (вручную) из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

Console.Clear();
Console.WriteLine("Ведите числа m и n");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int [,] array2d = new int[m, n];
decimal [] averegest = new decimal [n]; 
Console.WriteLine("Введите элементы массива в одну строку через запятую");
for (int i=0; i<m;i++)
{
    string text = Console.ReadLine();
    string[] Array = text.Split(",");
    for (int j=0; j<n; j++)
    {
        array2d[i,j]=Convert.ToInt32(Array[j]);
        Console.Write(array2d[i,j]+" ");
        averegest[j]=averegest[j]+(Convert.ToDecimal(array2d[i,j])/Convert.ToDecimal(m));
    }
Console.WriteLine();
}
Console.WriteLine("Средние арифмитические каждого столбца: ");
Console.WriteLine(string.Join("; ",averegest));
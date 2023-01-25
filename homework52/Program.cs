// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите число строк массива");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов массива");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];
CreateArray(m, n);
PrintArray(array);

int[,] CreateArray(int m, int n)
{
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            array[i, j] = rnd.Next(-10, 10);
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
double MidleSumm = 0;
double MidleSummColumn(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double MidleSumm = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            MidleSumm = MidleSumm + array[i, j];
        }
        Console.Write(MidleSumm / array.GetLength(0) + "| ");
    }
    return MidleSumm;
}
MidleSummColumn(array);

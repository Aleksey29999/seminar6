// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


Console.WriteLine("Введите число строк массива");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов массива");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число рядов массива");
int k = Convert.ToInt32(Console.ReadLine());

int[,,] array = new int[m, n, k];
CreateArray(m, n, k);
PrintArray(array);

int[,,] CreateArray(int m, int n, int k)
{
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int a = 0; a < k; a++)
                array[i, j, a] = rnd.Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int a = 0; a < array.GetLength(2); a++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j, a] + " (" + i + "," + j + "," + a + "," + ") ");
            }
            Console.WriteLine();
        }
    }
}

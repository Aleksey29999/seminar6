// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int m = 4;
int n = 4;

int[,] array = new int[m, n];
array = CreateArray(m, n);
Console.WriteLine("массив ");
PrintArray(array);
Console.WriteLine();


int[,] CreateArray(int m, int n)
{
int z = 1;
        for (int i = 0, j=0; j < n; j++)
        {
        array[i,j] =z;
        z++;
        }
        for (int i = 1, j=n-1; i < m; i++)
        {
        array[i,j] =z;
        z++;
        }
        for (int i = m-1, j=n-2; j >=0; j--)
        {
        array[i,j] =z;
        z++;
        }
 for (int i = m-2, j=0; i >0; i--)
        {
        array[i,j] =z;
        z++;
        }
        for (int i = 1, j=1; j <m-1; j++)
        {
        array[i,j] =z;
        z++;
        }

   for (int i = m-2, j=n-2; i<m-1; i++)
        {
        array[i,j] =z;
        z++;
        }

 for (int i = m-2, j=n-3; j>n-4; j--)
        {
        array[i,j] =z;
        z++;
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

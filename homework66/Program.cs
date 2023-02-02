// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Summ = 0;
int AllNaturalNumbers(int N, int M )
{
    
        if (Math.Abs(N - M )== 0)
        return 0;
    
    AllNaturalNumbers(N - 1,M);
    Summ = Summ + N;
    return Summ+M;
    }

Console.WriteLine("введите значение натурального числа N");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение натурального числа M");
int M = Convert.ToInt32(Console.ReadLine());
int temp = 0;
if (M > N)
{
temp = M;
M = N;
N = temp;
} 
AllNaturalNumbers(N, M);

Console.Write("Сумма чисел между N и M= " + (Summ+M));


//  Вариант  без проверки вводимых чисел 

// int Summ = 0;
// int AllNaturalNumbers(int N, int M)
// {
//     if (N < M)
//         return 0;
        
//     Summ = Summ + N;
//     Console.Write(Summ + " ");
//     return AllNaturalNumbers(N - 1,M);
// }

// Console.WriteLine("введите значение натурального числа N");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите значение натурального числа M");
// int M = Convert.ToInt32(Console.ReadLine());
// AllNaturalNumbers(N, M);
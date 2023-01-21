// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Вариант 1 с функцией
int SummPositiveNumbers (string message)
{
   int sum = 0;
 while (true)
{
     Console.WriteLine(message);
     string Number = (Console.ReadLine());
      if (int.TryParse(Number, out int N))
      { 
      if (N>0) 
        sum++; 
        Console.WriteLine("sum=" + sum);
      }
    else
    {
       Console.WriteLine("конец");
       Console.WriteLine("положительных чисел введено =" + sum);
        break;
    }
  }
return  sum;
}
int Sum = SummPositiveNumbers ("введите число");

// Вариант 2 без функции
// while (true)
// {
//    Console.WriteLine("Введите число");
//     string Number = (Console.ReadLine());
//     if (int.TryParse(Number, out int N))
//      { 
//       if (N>0) 
//       sum++; 
//       // Console.WriteLine("Number=" + Number);
//       Console.WriteLine("sum=" + sum);
//      }
//    else
//    {
//       Console.WriteLine("конец");
//       Console.WriteLine("sum=" + sum);
//        break;
//    }
//  }
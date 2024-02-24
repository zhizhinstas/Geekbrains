// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// if (n % 7 == 0 && n % 23 == 0)
//     Console.WriteLine("Кратно и 7 и 23");
// else
//     Console.WriteLine("Не кратно");


// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

// Console.Write("Введите координату X: ");
// double x = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату Y: ");
// double y = Convert.ToDouble(Console.ReadLine());
// while (x == 0)
// {
//   Console.Write("Вы ошиблись!\nВведите координату X: ");
//   x = Convert.ToDouble(Console.ReadLine());
// }
// while (y == 0)
// {
//   Console.Write("Вы ошиблись!\nВведите координату Y: ");
//   y = Convert.ToDouble(Console.ReadLine());
// }
// if (x > 0 && y > 0)
//   Console.WriteLine("I четверть");
// else if (x < 0 && y > 0)
//   Console.WriteLine("II четверть");
// else if (x < 0 && y < 0)
//   Console.WriteLine("III четверть");
// else
//   Console.WriteLine("IV четверть");

// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает 
// наибольшую цифру числа.

// int n = new Random().Next(10, 100);
// Console.WriteLine(n);
// int n1 = n / 10;
// int n2 = n % 10;
// if (n1 > n2)
//     Console.WriteLine(n1);
// else
//     Console.WriteLine(n2);

// Задача 4: Напишите программу, которая на вход принимает натуральное число N, 
// а на выходе показывает его цифры через запятую.

// Console.WriteLine("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// string s = n.ToString();
//  for (int i = 0; i < s.Length; i++)
//  {
//      Console.Write(s[i] + ",");
//  }
 
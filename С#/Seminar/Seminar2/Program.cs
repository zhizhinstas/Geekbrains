﻿     // Напишите программу, которая принимает на вход
     // трёхзначное число и удаляет вторую цифру этого
     // числа.
     // Примеры
     // a = 256 => 26
     // a = 891 => 81

// int number = 971;
// int firstDigit = number / 100; // 256 / 100 = 2
// int thirdDigit = number % 10; // 256 % 10 = 6
// int result = firstDigit * 10 + thirdDigit; // 2 * 10 + 6 = 26
// // $"Текст {number} текст {number / 100} текст"
// Console.WriteLine($"Результат от числа {number} => {result}");

// Напишите программу, которая принимает на вход трёхзначное
// число и возводит вторую цифру этого числа в степень, равную
// третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1


// Напишите программу, которая выводит третью с конца
// цифру заданного числа или сообщает, что третьей цифры
// нет.
// 456 => 4
// 7812 => 8
// 91 => Третьей цифры нет
// int number = 12345678;
// if (number < 100) // Число не ТРЕХЗНАЧНОЕ
// {
//    Console.WriteLine("Третьей цифры нет");
// }
// else // Третья цифра есть
// {
//     int thirdDigitFromEnd = number / 100 % 10; 
//     // 7812 / 100 % 10 = 78 % 10 = 8
//     Console.WriteLine($"Третья цифра от {number} с конца: {thirdDigitFromEnd}");
// }

// int a = 8;
//         // && - "И": апельсины И яблоки ()
//         if (a % 2 == 0 && a % 3 == 0)
//         {
//             Console.WriteLine("+"); // Число кратно 2 и 3(нацело делится)}
// }
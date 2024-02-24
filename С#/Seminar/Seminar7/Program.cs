// // Рекурсия - функция,которая вызывает саму себя же
// // Факториал - произ-е чисел от 1 до N включительно
// // 4! = 4 * 3 * 2 * ...

// // int FindFactorial (int n)
// // {
// //     // Базовый случай - случай остановки рекурсии
// //     if (n == 1) return 1;
// //     // Рекурсивный случай - сама рекурсия происходит именно здесь
// //     return n * FindFactorial(n - 1);
// // }
// // // 5 * 4 * 3 * 2 * 1 = 120
// // Console.WriteLine(FindFactorial(4));


// // Напишите программу, которая будет принимать на вход число и
// // возвращать сумму его цифр.
// // Пример
// // 123 => 6
// // 63 => 9

// // int SumOfDigits(int number)
// // {
// //     // Базовый случай 
// //     // 63 -> 3 + (63/10)
// //     // 63 -> 3 + 6 
// //     if (number / 10 == 0) return number;
// //     // Рекурсивный случай
// //     int result = number % 10 + SumOfDigits(number / 10);
// //     return result;
// // }
// // Console.WriteLine(SumOfDigits(56));


// // Задайте значение N. Напишите программу, которая выведет
// // все натуральные числа в промежутке от 1 до N.
// // N=5 => 1 2 3 4 5
// // start = 1, end = 5

// /// <summary>
// /// Метод печатает все числа от 1 до N
// /// </summary>
// /// <param name="start"> точка начала, у нас - 1 </param>
// /// <param name="end"> точка остановки, у нас - N </param>
// // start = 1, end = 5: 1 2 3 4 5
// // void ShowNumbers (int start, int end)
// // {
// //     // Базовый случай
// //     if (start == end)
// //     {
// //         Console.Write(start);
// //         return;
// //     }
// //     // Рекурсивный случай
// //     Console.Write(start + " ");
// //     ShowNumbers(start + 1, end);
// // }
// // Console.Write("Введите число N: ");
// // int N = Convert.ToInt32(Console.ReadLine());
// // ShowNumbers(1, N); // start = 1, end = N

// // Считать строку с консоли, содержащую латинские буквы.
// // Вывести на экран согласные буквы этой строки.

// // “hello” => h l l
// // “World” => W r l d
// // “Hello world!” => H l l w r l d

// // hello -> ello -> llo -> lo -> o -> (0 букв - длина строки = 0)
// void ShowConsonants(string str)
// {
//     // Базовый случай
//     if (str.Length == 0)
//     {
//         return;
//     }
//     // Рекурсивный случай
//     string vowels = "aoueyi"; // Гласные буквы
//     // hello -> h == a, o, y, e, y, i и если это буква -> согласная
//     if (char.IsLetter(str[0]) && !vowels.Contains(char.ToLower(str[0])))
//     {
//         Console.Write($"{str[0]} ");
//     }
//     // 'h' - 1 символ 
//     ShowConsonants(str.Substring(1));
//     // Я получаю строчку, начиная от 1 индекса в строчке
// }

// ShowConsonants("Hello world!");
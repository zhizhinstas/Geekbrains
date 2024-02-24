// // // тип_метода ИмяМетода (парм1, парм2...пармN)
// // // a, b - числа
// // // char ('+', '-') - 1 символ, обернут в ''
// // int Calculate(int a, int b, char sign)
// // {
// //     if (sign == '+')
// //     {
// //         return a + b; // Сумма чисел
// //     }
// //     else if (sign == '-')
// //     {
// //         return a - b; // Разность чисел
// //     }
// //     else if (sign == '*')
// //     {
// //         return a * b; // Произ-е чисел
// //     }
// //     else
// //     {
// //         Console.WriteLine("Введен неизвестный знак арифм. операции");
// //         return 0;
// //     }
// // }

// // // Вызов метода:
// // int res = Calculate(10, 7, '*'); 
// // Console.WriteLine($"res => {res}");
// // Console.WriteLine(Calculate(2, 3, '+')); // 5, a = 2, b = 3, sign = '+'
// // Console.WriteLine(Calculate(2, 3, '-')); // -1
// // Console.WriteLine(Calculate(2, 3, '*')); // 6
// // Console.WriteLine(Calculate(2, 3, ';')); // Введен неизвестный знак арифм. операции

// // Задайте массив из N случайных целых чисел (N вводится с
// // клавиатуры).
// // Найдите количество чисел, которые оканчиваются на 1 и
// // делятся нацело на 7.
// // Пример
// // [1 5 11 21 81 4 0 91 2 3]
// // => 2

// // size - размер массива; minRange - мин. число в рандоме
// // maxRange - макс. число в рандоме
// // int[] CreateArray(int size, int minRange, int maxRange)
// // {
// //     int[] array = new int[size]; // Массив на size элементов
// //     for (int i = 0; i < array.Length; i++)
// //     {
// //         array[i] = new Random().Next(minRange, maxRange + 1);
// //     }
// //     return array;
// // }

// // int GetCount (int[] arr)
// // {
// //     int count = 0;
// //     for (int i = 0; i < arr.Length; i++)
// //     {
// //         // && - "и" (апельсины И яблоки)
// //         if (arr[i] % 7 == 0 && arr[i] % 10 == 1)
// //         {
// //             count++;
// //         }
// //     }
// //     return count;
// // }


// // // Вызов метода
// // Console.Write("Введите размер массива: ");
// // int N = Convert.ToInt32(Console.ReadLine());
// // // int size = N, int minRange = 10, int maxRange = 90
// // int[] res = CreateArray(N, 10, 90);
// // Console.WriteLine($"Массив: [ {string.Join("; ", res)} ]");
// // Console.WriteLine($"Total: {GetCount(res)}");

// // Заполните массив на N (вводится с консоли, не более 8)
// // случайных целых чисел от 0 до 9.
// // Сформируйте целое число, которое будет состоять из цифр из
// // массива. Старший разряд числа находится на 0-м индексе,
// // младший – на последнем.
// // Пример
// // [1 3 2 4 2 3] => 132423
// // [2 3 1] => 231

// int[] CreateArray(int size)
// {
//     int[] array = new int[size]; // Массив на size элементов
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(10); // [0,9]:0,1,2,3,4,5,6,7,8,9
//     }
//     return array;
// }
// // [2,3,9] => 239
// int ConvertArrayToInteger(int[] array)
// {
//     int result = 0;
//     for (int i = 0, j = array.Length - 1; i < array.Length; i++, j--)
//     {
//         result = result + array[i] * (int)Math.Pow(10, j);
//     }
//     return result;
// }

// Console.Write("Введите размер массива: ");
// int N = Convert.ToInt32(Console.ReadLine());
// // int size = N, int minRange = 10, int maxRange = 90
// int[] res = CreateArray(N); // Массив на N элементов , эл: [0,9]
// Console.WriteLine($"Массив: [ {string.Join("; ", res)} ]");
// if (N > 8)
// {
//     Console.WriteLine("Размер > 8 элементов");
//     return; // Ломает программу, если размер > 8 эл
// }
// Console.WriteLine($"Число: {ConvertArrayToInteger(res)}");

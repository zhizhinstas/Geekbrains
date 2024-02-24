// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//  Использовать рекурсию, не использовать циклы.

// Console.Clear ();
// Console.Write("Введите значение M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// void Rek(int m, int n)
// {
// if (m > n)
// return;
// if (m != 0)
// {
// Console.Write($" {m} ");
// }
// Rek(m+1,n);
// }
// Rek(m,n);

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// int Akkerman(int M, int N)
// {
//     int tmp = 0;
//     if (M == 0) return N + 1;
//     else if (N == 0) { return Akkerman(M - 1, 1); }
//     return tmp + Akkerman(M - 1, Akkerman(M, N - 1));

// }

// while (true)
// {
//     int M = 0;
//     int N = 0;
//     Console.WriteLine("Введите число M: ");
//     Int32.TryParse(Console.ReadLine(), out M);
//     Console.WriteLine("Введите число N: ");
//     Int32.TryParse(Console.ReadLine(), out N);

//     if (M == 0 && N == 0)
//     { break; }

//     Console.WriteLine($"Функция Аккермана для чисел {M} и {N} = {Akkerman(M, N)}");
// }


// Задача 3: Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.


int[] CreateArray(int size, int max, int min)
{
    int[] array = new int[size];
    Random rand = new();
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(min, max + 1);
    }
    return array;
}

int[] array = CreateArray(10, 10, 0);

int[] ArraySwap(int[] array, int index)
{
    if (index <= 0)
    {
        return array;
    }
    int temp = array[index];
    array[index] = array[array.Length - index - 1];
    array[array.Length - index - 1] = temp;
    return ArraySwap(array, index -= 2);
}
string PrintArray(int [] array)
        {
            return string.Join(", ",array);
        }
Console.WriteLine($"Произвольный массив => [{PrintArray(array)}]");
Console.WriteLine($"Перевернутый массив => [{PrintArray(ArraySwap(array,array.Length-1))}]");
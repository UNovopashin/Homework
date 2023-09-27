// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите значение N: ");
//         int n = int.Parse(Console.ReadLine());

//         PrintNaturalNumbers(n);

//         Console.WriteLine("Программа завершена.");
//     }

//     // Функция для вывода натуральных чисел от N до 1 с использованием рекурсии
//     static void PrintNaturalNumbers(int n)
//     {
//         if (n <= 0)
//         {
//             return; // Базовый случай: если n меньше или равно 0, завершаем рекурсию
//         }

//         Console.WriteLine(n); // Выводим текущее значение n
//         PrintNaturalNumbers(n - 1); // Рекурсивно вызываем функцию с уменьшенным значением n
//     }
// }


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите значение M: ");
//         int m = int.Parse(Console.ReadLine());

//         Console.Write("Введите значение N: ");
//         int n = int.Parse(Console.ReadLine());

//         if (m > n)
//         {
//             Console.WriteLine("M не может быть больше N. Пожалуйста, введите корректные значения.");
//         }
//         else
//         {
//             int sum = SumNaturalNumbers(m, n);
//             Console.WriteLine($"Сумма натуральных чисел от {m} до {n} равна: {sum}");
//         }
//     }

//     // Функция для вычисления суммы натуральных чисел от M до N с использованием рекурсии
//     static int SumNaturalNumbers(int m, int n)
//     {
//         if (m > n)
//         {
//             return 0; // Базовый случай: если M больше N, возвращаем 0
//         }

//         return m + SumNaturalNumbers(m + 1, n); // Рекурсивно вызываем функцию для следующего числа и добавляем его к сумме
//     }
// }



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение m: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите значение n: ");
        int n = int.Parse(Console.ReadLine());

        int result = AckermannFunction(m, n);

        Console.WriteLine($"Значение функции Аккермана A({m}, {n}) равно {result}");
    }

    // Рекурсивная функция для вычисления функции Аккермана
    static int AckermannFunction(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return AckermannFunction(m - 1, 1);
        }
        else
        {
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        }
    }
}

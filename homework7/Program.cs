// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.WriteLine("Введите первую размерность");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите вторую размерность");
// int columns = Convert.ToInt32(Console.ReadLine());

// Random matrix = new Random();
// double[,] array = new double[rows, columns];

// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < columns; j++)
//     {
//         array[i, j] = matrix.NextDouble();
//     }
// }
// Console.WriteLine("Сгенерированный массив:");
// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < columns; j++)
//     {
//         Console.Write($"{array[i, j]:F2}\t");
//     }
//     Console.WriteLine();
// }
      


// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


// using System;

// namespace ArrayElementValue
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int[,] array = {
//                 { 1, 2, 3 },
//                 { 4, 5, 6 },
//                 { 7, 8, 9 }
//             };

//             Console.Write("Введите номер строки: ");
//             int row = int.Parse(Console.ReadLine());

//             Console.Write("Введите номер столбца: ");
//             int column = int.Parse(Console.ReadLine());

//             int rows = array.GetLength(0);
//             int columns = array.GetLength(1);

//             if (row >= 0 && row < rows && column >= 0 && column < columns)
//             {
//                 int element = array[row, column];
//                 Console.WriteLine($"Значение элемента: {element}");
//             }
//             else
//             {
//                 Console.WriteLine("Такого элемента не существует.");
//             }
//         }
//     }
// }



// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using System;

namespace AverageColumnValues
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем двумерный массив
            int[,] array = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int rows = array.GetLength(0); // Количество строк
            int columns = array.GetLength(1); // Количество столбцов
            
            double[] columnAverages = new double[columns];

            for (int j = 0; j < columns; j++)
            {
                int sum = 0;
                for (int i = 0; i < rows; i++)
                {
                    sum += array[i, j];
                }
                columnAverages[j] = (double)sum / rows;
            }

            Console.WriteLine("Средние значения столбцов:");
            for (int j = 0; j < columns; j++)
            {
                Console.WriteLine($"Столбец {j + 1}: {columnAverages[j]}");
            }
        }
    }
}

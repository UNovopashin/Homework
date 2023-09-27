// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите количество строк: ");
//         int rows = int.Parse(Console.ReadLine());

//         Console.Write("Введите количество столбцов: ");
//         int columns = int.Parse(Console.ReadLine());

//         // Создаем двумерный массив
//         int[,] array = new int[rows, columns];

//         // Заполняем массив случайными числами (для примера)
//         Random random = new Random();
//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < columns; j++)
//             {
//                 array[i, j] = random.Next(100); // Для примера генерируем случайные числа от 0 до 99
//             }
//         }

//         // Выводим сгенерированный массив на экран
//         Console.WriteLine("Сгенерированный массив:");
//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < columns; j++)
//             {
//                 Console.Write(array[i, j] + " ");
//             }
//             Console.WriteLine();
//         }

//         // Упорядочиваем каждую строку по убыванию
//         for (int i = 0; i < rows; i++)
//         {
//             // Создаем временный одномерный массив для сортировки
//             int[] rowArray = new int[columns];
//             for (int j = 0; j < columns; j++)
//             {
//                 rowArray[j] = array[i, j];
//             }

//             // Сортируем временный массив
//             Array.Sort(rowArray);
//             Array.Reverse(rowArray);

//             // Копируем отсортированные значения обратно в исходный массив
//             for (int j = 0; j < columns; j++)
//             {
//                 array[i, j] = rowArray[j];
//             }
//         }

//         // Выводим упорядоченный массив на экран
//         Console.WriteLine("\nУпорядоченный массив по убыванию:");
//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < columns; j++)
//             {
//                 Console.Write(array[i, j] + " ");
//             }
//             Console.WriteLine();
//         }
//     }
// }


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// using System;

// class Program
// {
//     static void Main()
//     {
//         // Создаем прямоугольный двумерный массив
//         int[,] array = {
//             { 1, 2, 3 },
//             { 4, 5, 6 },
//             { 7, 8, 9 }
//         };

//         int rows = array.GetLength(0); // Количество строк
//         int columns = array.GetLength(1); // Количество столбцов

//         // Выводим сгенерированный массив на экран
//         Console.WriteLine("Сгенерированный массив:");
//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < columns; j++)
//             {
//                 Console.Write(array[i, j] + " ");
//             }
//             Console.WriteLine();
//         }

//         int minSum = int.MaxValue; // Начальное значение минимальной суммы
//         int minSumRow = -1; // Индекс строки с минимальной суммой

//         // Находим строку с наименьшей суммой элементов
//         for (int i = 0; i < rows; i++)
//         {
//             int rowSum = 0;
//             for (int j = 0; j < columns; j++)
//             {
//                 rowSum += array[i, j];
//             }
//             if (rowSum < minSum)
//             {
//                 minSum = rowSum;
//                 minSumRow = i;
//             }
//         }

//         // Выводим результат
//         Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRow + 1}"); // +1, так как индексы начинаются с 0
//     }
// }


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите количество строк первой матрицы: ");
//         int rows1 = int.Parse(Console.ReadLine());

//         Console.Write("Введите количество столбцов первой матрицы: ");
//         int columns1 = int.Parse(Console.ReadLine());

//         Console.Write("Введите количество строк второй матрицы: ");
//         int rows2 = int.Parse(Console.ReadLine());

//         Console.Write("Введите количество столбцов второй матрицы: ");
//         int columns2 = int.Parse(Console.ReadLine());

//         // Создаем первую матрицу и заполняем случайными числами
//         int[,] matrix1 = GenerateRandomMatrix(rows1, columns1);
        
//         // Создаем вторую матрицу и заполняем случайными числами
//         int[,] matrix2 = GenerateRandomMatrix(rows2, columns2);

//         // Проверяем, можно ли умножить матрицы
//         if (columns1 != rows2)
//         {
//             Console.WriteLine("Умножение невозможно: количество столбцов первой матрицы не равно количеству строк второй матрицы.");
//             return;
//         }

//         // Выводим первую матрицу
//         Console.WriteLine("Первая матрица:");
//         PrintMatrix(matrix1);

//         // Выводим вторую матрицу
//         Console.WriteLine("Вторая матрица:");
//         PrintMatrix(matrix2);

//         // Создаем матрицу для хранения результата
//         int[,] resultMatrix = new int[rows1, columns2];

//         // Вычисляем произведение матриц
//         for (int i = 0; i < rows1; i++)
//         {
//             for (int j = 0; j < columns2; j++)
//             {
//                 int sum = 0;
//                 for (int k = 0; k < columns1; k++)
//                 {
//                     sum += matrix1[i, k] * matrix2[k, j];
//                 }
//                 resultMatrix[i, j] = sum;
//             }
//         }

//         // Выводим результат умножения
//         Console.WriteLine("Результат умножения матриц:");
//         PrintMatrix(resultMatrix);
//     }

//     // Метод для генерации и заполнения матрицы случайными числами
//     static int[,] GenerateRandomMatrix(int rows, int columns)
//     {
//         int[,] matrix = new int[rows, columns];
//         Random random = new Random();

//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < columns; j++)
//             {
//                 matrix[i, j] = random.Next(1, 101); // Генерируем случайные числа от 1 до 100
//             }
//         }

//         return matrix;
//     }

//     // Метод для вывода матрицы на экран
//     static void PrintMatrix(int[,] matrix)
//     {
//         int rows = matrix.GetLength(0);
//         int columns = matrix.GetLength(1);

//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < columns; j++)
//             {
//                 Console.Write(matrix[i, j] + " ");
//             }
//             Console.WriteLine();
//         }
//     }
// }



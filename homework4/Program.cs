// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int GetMultiplay()
// {
//     int count = 0;
//     int result = num1;

//     while (count < num2 - 1)
//     {
//         result = result * num1;
//         count ++;
//     }
//     return result;
// }
// Console.WriteLine(GetMultiplay());



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int GetSum()
// {
//   int sum = 0;
//   while(num > 0)
//   {
//     sum = sum + num % 10;
//     num = num / 10;
//   }
//   return sum;
// }
// Console.WriteLine(GetSum());



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];
void GetArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 34);
        Console.Write(array[i]+ " ");
    }
}
GetArray();
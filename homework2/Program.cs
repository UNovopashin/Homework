// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Введите трёхзначное число");
// int num = Convert.ToInt32(Console.ReadLine());

// int result1 = num / 10;
// int result = result1 % 10;

// Console.WriteLine("Вторая цыфра заданного вами числа, " + result);


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Введите число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int result = 0;

// if (num1 >= 100)
// {
//     while (num1 > 999)
//     {
//         num1 = num1 / 10;
//     }
// result = num1 % 10;
// Console.WriteLine("Третья цифра заданного числа " + result);
// }

// if ((num1 < 100) && (num1 > -100))
// {
//     Console.WriteLine("Третьей цифры нет");
// }



// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число, обозначающее день недели");
int num1 = Convert.ToInt32(Console.ReadLine());

if ((num1 < 1) || (num1 > 7))
{
    Console.WriteLine("Такого дня недели нет");
} 
else if (num1 <= 5)
{
    Console.WriteLine("Нет");
}
else
{
    Console.WriteLine("Да");
}
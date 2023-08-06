// Задача 19
// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите пятизначное число ");
// string number = Console.ReadLine();
// int ind = number.Length;

// if (ind == 5)
// {
//     if (number[0] == number[4] && number[1] == number[3])
//     {
//         Console.WriteLine("Данное число является палиндромом");
//     }
//     else
//     {
//         Console.WriteLine("Данное число не является палиндромом");
//     }
// }
// else
// {
//     Console.WriteLine("Введённое число не является пятизначным");
// }

//Задача 21 
// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите точку координат X1");
// int X1 = Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine("Введите точку координат Y1");
// int Y1 = Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine("Введите точку координат Z1");
// int Z1 = Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine("Введите точку координат X2");
// int X2 = Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine("Введите точку координат Y2");
// int Y2 = Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine("Введите точку координат Z2");
// int Z2 = Convert.ToInt32 (Console.ReadLine());

// double num = Math.Sqrt(Math.Pow((X2-X1),2)+ Math.Pow((Y2-Y1),2)+Math.Pow((Z2-Z1),2));
// Console.WriteLine(num);

// Задача 23
// Напишите программу, которая принимает на вход 
// число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
    Console.WriteLine(Math.Pow (i,3));
}

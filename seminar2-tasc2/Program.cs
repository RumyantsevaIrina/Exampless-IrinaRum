﻿// Задание 2. Работа в сессионных залах
// Семинар 2. Простые алгоритмы на C#
// Напишите программу, которая принимает на вход трёхзначное
// число и возводит вторую цифру этого числа в степень, равную
// третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1
//первый вариант
 int a = 487;

// double result = Math.Pow((a % 100) / 10, (a % 10));

// System.Console.WriteLine(result);
// второй вариант
int second = (a % 100) / 10;
int therd = a % 10;
int result = 1;

for (int i = 1; i <= therd; i++)
{
    result = result*second;
}

System.Console.WriteLine(result);

﻿// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 =>

System.Console.Write("input three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 100 && num <= 999)
{
    int ed = num % 10;
    int sot = num / 100;
    System.Console.WriteLine($"{num} -> {ed + sot}");
}
else
{
    System.Console.WriteLine("You input not three-digit number");
}
﻿//Напишите программу, которая принимает на вход
//трёхзначное целое число и на выходе показывает сумму
//первой и последней цифры этого числа.
//456 => 10
//782 => 9
//918 => 17
using System.Diagnostics.CodeAnalysis;

int a = 918;

int a1 = a / 100;
int a2 = a % 10;

int sum = a1 + a2;
System.Console.WriteLine(sum);
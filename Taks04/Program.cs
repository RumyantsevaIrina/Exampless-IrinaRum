// Напишите программу, которая принимает на 
// вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

Console.WriteLine("Введите три числа, и узнайте, какое из них имеет максимальное значение.");
Console.Write("Введите первое число и нажмите ENTER: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число и нажмите ENTER: ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число и нажмите ENTER: ");
int number3 = int.Parse(Console.ReadLine());
int maxNum = 0;
if (number1 > maxNum) maxNum = number1;
if (number2 > maxNum) maxNum = number2;
if (number3 > maxNum) maxNum = number3;
Console.Write("Максимальное значение имеет число " + maxNum);
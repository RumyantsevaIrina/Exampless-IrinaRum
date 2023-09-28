// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// int number = new Random().Next(100, 1000);// 999+1
// Console.WriteLine(number);
// int firsDigit = number / 100;
// int thrdDigit = number % 10;
// int result = firsDigit * 10 + thrdDigit;
// Console.WriteLine(result);

int DeleteSecondDigit(int num)
{
 int firsDigit = num / 100;
 int thrdDigit = num % 10;
 return firsDigit * 10 + thrdDigit; 
}
int number = new Random().Next(100, 1000);
Console.WriteLine(number);
int result = DeleteSecondDigit(number);
Console.WriteLine(result);
// Напишите программу, которая 
//выводит случайное число из отрезка [10, 99] 
//и показывает наибольшую цифру числа.

// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100); // 99+1
Console.WriteLine($"Случайное число из отрезка [10, 99] -> {number}");

int firstDigit = number / 10; //78 / 10 = 7
int secontDigit = number % 10; //78 = 70 + 8

if(firstDigit > secontDigit) Console.WriteLine($"Наибольшая цифра числа -> {firstDigit}");// второй способ
else Console.WriteLine ($"Наибольшая цифра числа -> {secontDigit}");

int maxDigit = firstDigit > secontDigit ? firstDigit : secontDigit; // второй способ Тернарный оператор, где ? это тогда, а : иначе
Console.WriteLine ($"Наибольшая цифра числа -> {maxDigit}");

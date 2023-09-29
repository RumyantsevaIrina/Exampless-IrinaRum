// Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

int GetUserInput(string str)
{
    Console.Write($"{str}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

bool DivisionTo7and23(int num)
{
    return num % 7 == 0 && num % 23 == 0;
}

int number = GetUserInput("Enter a number: ");
bool result = DivisionTo7and23(number);

Console.Write(result ? $"{number} -> да" : $"{number} -> нет");

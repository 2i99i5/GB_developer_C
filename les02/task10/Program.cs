/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

string GetSecondDigit(int number)
{
    number/=10;
    return $"Вторая цифра в трехзначном числе: {number % 10}";
}

Console.WriteLine("Введите трехзначное число");
int num = int.Parse(Console.ReadLine()??"");

//  первый вариант: string - массив char
string strNum = num.ToString();
Console.WriteLine($"Вторая цифра в трехзначном числе: {strNum[1]}");

// второй вариант: работает только если число трёхзначное
Console.WriteLine(GetSecondDigit(num));

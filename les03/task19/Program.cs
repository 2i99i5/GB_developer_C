/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да
*/

int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

void PrintData(string prefix, string value)
{
    Console.WriteLine(prefix + value);
}

string PalindromCheck(double number)
{
    int digitCount = (int)Math.Log10(number) + 1; // количество цифр в числе
    int i = 0;
    while (i < digitCount - i - 1)
    {
        int digitLeft = (int)(number/Math.Pow(10,i)%10);  // вычисление цифры слева
        int digitRight = (int)(number/Math.Pow(10,digitCount - i - 1)%10); // вычисление цифры справа
        if (digitLeft != digitRight)
        {
            return "нет";
        }
        i++;
    }
    return "да";
}

double num = ReadData("Введите пятизначное число");

PrintData("Число является палиндромом? - ", PalindromCheck(num));

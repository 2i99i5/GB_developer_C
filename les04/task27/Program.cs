/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int NumLen (int number)
// возвращает количество цифр в числе
{
    if (number > 0) return (int)(Math.Log10(number)) + 1;
    else if (number == 0) return 1;
    return (int)(Math.Log10(-number)) + 2;
}

int DigitSum (int number)
// суммирует цифры числа
{
    int sum = 0;
    if (number<0) number = -number;
    int len = NumLen(number);
    for(int i=0; i < len; i++)
    {
        sum += (number%10);
        number /= 10;
    }
    return sum;
}

Console.WriteLine($"Введите число: ");
int num = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine($"Сумма цмфр в числе равна {DigitSum(num)}");

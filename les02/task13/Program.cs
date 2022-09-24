/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/


//  первый вариант: string - массив char
string GetDigitString(int number, int index)
{
    string strNum = number.ToString();
    if (strNum.Length > index - 1) 
    {
        return $"третья цифра: {strNum[index - 1]}";
    }
    else 
    {
        return $"третьей цифры нет";
    }
}

int LengthNumber(int number)
{
    int i = 0;
    while(number > 0) 
    {
        i++;
        number/=10;
    }
    return i;
}

// второй вариант: определяем кол-во цифр, затем повторно проходим с остатком от деления на 10
string GetDigitNumber(int number, int index)
{
    int lenNum = LengthNumber(number);  // количество цифр
    int i = 0;
    if (lenNum >= index)
    {
        while(number > 0) 
        {
            if (i == lenNum - index)
            {
                return $"третья цифра: {number % 10}";
            }
            i++;
            number/=10;
        }
    }
    return $"третьей цифры нет";
}


Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()??"");


Console.WriteLine(GetDigitString(num, 3));

Console.WriteLine(GetDigitNumber(num, 3));

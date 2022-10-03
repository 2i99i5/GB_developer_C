/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
ввод элеменетов через консоль (через запятую. использовать метод string.Split())
*/
int [] StringParse (string stringArray)
{
    stringArray = stringArray.Replace(" ", "");  // удаляем пробелы
    // делим строку на элементы массива
    int[] arr = stringArray.Split(',').Select(int.Parse).ToArray();
    return arr;
}

void PrintArray (string stringArray)
{
    Console.WriteLine("[{0}]", string.Join(", ", StringParse(stringArray)));
}

Console.WriteLine($"Введите массив через запятую: ");
string stringArray = (Console.ReadLine() ?? "");

PrintArray (stringArray);
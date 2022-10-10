// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int GetArrayLength()
// Метод запрашивает длину массива
{
    Console.WriteLine("Введите длину ");
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

int[] InitArray(int lenArr)
// Метод заполняет массив определнной длины
{
    int[] array = new int[lenArr];
    Console.WriteLine($"Заполните массив чисел из {lenArr} элементов:");
    for (int i = 0; i < lenArr; i++)
    {
        array[i] = int.Parse(Console.ReadLine() ?? "");
    }
    return array;
}

void PositiveElementCount(int[] array)
// выводит сообщение с количеством положительных элементов
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine($"В массиве {count} элемента(-ов) больше нуля");
}


int lenArr = GetArrayLength();
int[] array = InitArray(lenArr);
PositiveElementCount(array);
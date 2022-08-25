// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2-> 2
// 1, -7, 567, 89, 223-> 3

int CountPlus(string[] arrStr)
{
    int count = 0;
    for (int i = 0; i < arrStr.Length; i++)
    {
        if (Convert.ToInt32(arrStr[i]) > 0) count++;
    }
    return count;
}

Console.Write("Введите числа через пробел: ");
string[] str = Console.ReadLine().Split(" ");
Console.WriteLine($"Всего чисел больше 0: {CountPlus(str)}");
// Задача 50. Напишите программу, которая на вход принимает число, и возвращает индексы этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17->такого числа в массиве нет

int[,] FillingAnArray(int len0, int len1, int min, int max)
{
    int[,] array = new int[len0, len1];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0} ", array[i, j]);
        }
        Console.WriteLine();
    }
}

string FindNumber(int[,] array, int number)
{
    string result = string.Format("Числа {0} в массиве нет", number);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
            {
                result = string.Format("Число {0} находится в массиве под индексами {1} {2}", number, i, j);
                return result;
            }
        }
    }
    return result;
}

int[,] arrNumbers = FillingAnArray(3, 4, 0, 9);
PrintArray(arrNumbers);
Console.WriteLine($"{FindNumber(arrNumbers, 5)}");
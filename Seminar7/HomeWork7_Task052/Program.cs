// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void OutputAverage(int[,] array)
{
    double[] average = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            average[j] += array[i, j];
        }
    }

    for (int i = 0; i < average.Length; i++)
    {
        average[i] /= array.GetLength(0);
        Console.Write("{0:f1}; ", average[i]);
    }
}

int[,] arrNumbers = FillingAnArray(3, 4, 0, 9);
PrintArray(arrNumbers);
OutputAverage(arrNumbers);
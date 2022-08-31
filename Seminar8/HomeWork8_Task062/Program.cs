// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
                Console.Write("0{0} ", array[i, j]);
            else
                Console.Write("{0} ", array[i, j]);
        }
        Console.WriteLine();
    }
}

int[,] FillArray(int[,] array)
{
    int tmp = 1;
    int i = 0, j = 0;
    while (tmp <= array.GetLength(0) * array.GetLength(1))
    {
        array[i, j] = tmp;
        tmp++;
        if (i <= j + 1 && i + j < array.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= array.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > array.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    return array;
}

int[,] matrix = new int[4, 4];

PrintArray(FillArray(matrix));
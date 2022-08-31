// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

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

int[,] ArrangeRowsOfArray(int[,] array)
{
    int tmp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    tmp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = tmp;
                }
            }
        }
    }
    return array;
}

int[,] arrNumbers = FillingAnArray(3, 4, 1, 9);
PrintArray(arrNumbers);
Console.WriteLine();
PrintArray(ArrangeRowsOfArray(arrNumbers));
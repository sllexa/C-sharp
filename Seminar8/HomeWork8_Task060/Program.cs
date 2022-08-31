// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/* Массив размером 2 x 2 x 2
66(0,0,0) 25(0, 1, 0)
34(1, 0, 0) 41(1, 1, 0)
27(0, 0, 1) 90(0, 1, 1)
26(1, 0, 1) 55(1, 1, 1)*/

int InputNumbers(string input)
{
    Console.Write(input);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] FillingAnArray(int x, int y, int z, int[] arrValues)
{
    int[,,] array = new int[x, y, z];
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = arrValues[count];
                count++;
            }
        }
    }
    return array;
}

int [] CreateUniqueValues(int x, int y, int z, int min, int max)
{
    int[] array = new int[x * y * z];
    for (int i = 0; i < array.Length; i++)
    {
        bool contains;
        int next;
        do
        {
            next = new Random().Next(min, max + 1);
            contains = false;
            for (int j = 0; j < i; j++)
            {
                if (array[j] == next)
                {
                    contains = true;
                    break;
                }
            }
        } while (contains);
        array[i] = next;
    }
    return array;
}

Console.WriteLine($"\nВведите размер массива X x Y x Z:");
int x = InputNumbers("Введите X: ");
int y = InputNumbers("Введите Y: ");
int z = InputNumbers("Введите Z: ");
Console.WriteLine();
int[,,] arrNumbers = FillingAnArray(x, y, z, CreateUniqueValues(x, y, z, 10, 99));
PrintArray(arrNumbers);

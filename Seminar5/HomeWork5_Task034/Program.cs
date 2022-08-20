// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int CountEvenNumbers(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) result++;
    }
    return result;
}

int[] FillingAnArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
        Console.Write($"{arr[i]} ");
    }
    return arr;
}

int[] array = new int[5];
array = FillingAnArray(array);
Console.WriteLine($"-> {CountEvenNumbers(array)}");

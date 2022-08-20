// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6]-> 0

int OddSum(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0) sum += arr[i];
    }
    return sum;
}

int[] FillingAnArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-100, 100);
    }
    Console.WriteLine(String.Join(", ", arr));
    return arr;
}

int[] array = new int[5];
array = FillingAnArray(array);
Console.WriteLine($"{OddSum(array)}");
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19-> [1, 2, 5, 7, 19]
// 6, 1, 33-> [6, 1, 33]

void PrintArray()
{
    int count = 8;
    int[] arr = new int[count];
    string str1 = "", str2 = "";

    for (int i = 0; i < count; i++)
    {
        arr[i] = new Random().Next(1, 100);
        str1 = (i == 0) ? "[" : "";
        str2 = (i == count - 1) ? "]" : ", ";
        Console.Write($"{str1 + arr[i] + str2}");
    }
}

PrintArray();
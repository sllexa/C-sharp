// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5-> 243(3⁵)
// 2, 4-> 16

int getDegree()
{
    int[] numbers = new int[2];
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"Введите число {i + 1}: ");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }

    int result = 1;
    for (int i = 0; i < numbers[1]; i++)
    {
        result *= numbers[0];
    }
    return result;
}

Console.WriteLine($"{getDegree()}");
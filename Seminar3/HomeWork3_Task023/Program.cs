// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void tableOutput(int number)
{
    for (int i = 1; i <= number; i++)
    {
        string mes = (i == number) ? "" : ", ";
        Console.Write($"{Math.Pow(i, 3)}" + mes);
    }
}

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

tableOutput(N);

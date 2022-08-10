// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Input number: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= N; i++)
{
    if (i % 2 == 0)
    {
        string mes = (i == N || i == N - 1) ?  i + "" : i + ", ";
        Console.Write(mes);
    }
}

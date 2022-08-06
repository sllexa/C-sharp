// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Input first number: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int second = Convert.ToInt32(Console.ReadLine());

int max = (first > second) ? first : second;

Console.WriteLine("Max number: " + max);

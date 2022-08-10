// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456-> 5
Console.Write("Input three-digit number: ");
int input = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(input % 100 / 10);
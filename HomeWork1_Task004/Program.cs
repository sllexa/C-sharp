// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел
Console.Write("Input first number: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int second = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number: ");
int third = Convert.ToInt32(Console.ReadLine());

int max = (first > second) ? first : second; 
max = (third > max) ? third : max;

Console.WriteLine("Max number: " + max);
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

string message = (number % 2 == 0) ? "Yes, even number" : "No, odd number";

Console.WriteLine(message);

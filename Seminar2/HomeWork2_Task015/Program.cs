// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6->да
Console.Write("Введите число дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1 || number > 7)
{
    Console.WriteLine("Такого дня недели нет.");
}
else
{
    string message = (number == 6 || number == 7) ? "Да, сегодня выходной." : "Нет";
    Console.WriteLine(message);
}
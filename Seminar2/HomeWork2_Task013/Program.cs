// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645-> 5
string strNumber = new Random().Next(10, 1000).ToString();
Console.WriteLine($"Number {strNumber} is generated.");

if (strNumber.Length == 2)
{
    Console.WriteLine("No third digit");
}
else
{
    Console.WriteLine(strNumber[2]);
}
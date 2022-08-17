// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452-> 11
// 82-> 10
// 9012-> 12

int Sum(int number)
{
    string strNumber = Convert.ToString(number);
    number = 0;
    for (int i = 0; i < strNumber.Length; i++)
    {
        number += Convert.ToInt32(strNumber[i].ToString());
    }
    return number;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{Sum(number)}");
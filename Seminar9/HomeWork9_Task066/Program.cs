// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30

int M = 1, N = 15;
int sum = 0;
SumNumbers(M, N);
Console.WriteLine($"{sum}");

void SumNumbers(int min, int max)
{
    sum += min++;
    if (min <= max)
    {
        SumNumbers(min, max);
    }
}
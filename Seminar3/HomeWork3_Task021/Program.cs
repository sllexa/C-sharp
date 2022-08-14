// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B(2, 1, -7), -> 15.84
// A(7, -5, 0); B(1, -1, 9)-> 11.53

double getDistance(int[] a, int[] b)
{
    return Math.Round(Math.Sqrt(Math.Pow(b[0] - a[0], 2) + Math.Pow(b[1] - a[1], 2) + Math.Pow(b[2] - a[2], 2)), 2);
}

int[] EnteringValues(int number)
{
    char sim = '0';
    int[] arr = new int[3];

    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) sim = 'x';
        if (i == 1) sim = 'y';
        if (i == 2) sim = 'z';

        Console.Write($"Введите кординату {sim} {number} точки: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int[] a = new int[3];
int[] b = new int[3];

a = EnteringValues(1);
b = EnteringValues(2);

Console.WriteLine($"Расстояние между двумя точками: {getDistance(a, b)}");

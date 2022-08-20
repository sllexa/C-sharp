// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] FillArrays(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble() * 10;
        Console.Write("{0,6:N2}", array[i]);
    }
    return array;
}

double Difference(double[] array)
{
    double max = array[0];
    double min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    return max - min;
}

double[] arrNumbers = new double[5];
arrNumbers = FillArrays(arrNumbers);

Console.WriteLine("  ->{0,6:N2}", Difference(arrNumbers));
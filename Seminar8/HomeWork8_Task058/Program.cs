// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] FillingAnArray(int len0, int len1, int min, int max)
{
    int[,] array = new int[len0, len1];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0} ", array[i, j]);
        }
        Console.WriteLine();
    }
}

int InputNumbers(string input)
{
    Console.Write(input);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] MatrixMultiplication(int[,] first, int[,] second)
{
    int[,] result = new int[first.GetLength(0), second.GetLength(1)];
    int sum = 0;
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            sum = 0;
            for (int k = 0; k < first.GetLength(1); k++)
            {
                sum += first[i, k] * second[k, j];
            }
            result[i, j] = sum;
        }
    }
    return result;
}

int rows1 = InputNumbers("Введите число строк 1-й матрицы: ");
int col1 = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int rows2 = col1;
int col2 = InputNumbers("Введите число столбцов 2-й матрицы: ");

int[,] matrixFirst = FillingAnArray(rows1, col1, 1, 9);
PrintArray(matrixFirst);
Console.WriteLine();
int[,] matrixSecond = FillingAnArray(rows2, col2, 1, 9);
PrintArray(matrixSecond);
Console.WriteLine("Произведение двух матриц:");
PrintArray(MatrixMultiplication(matrixFirst, matrixSecond));
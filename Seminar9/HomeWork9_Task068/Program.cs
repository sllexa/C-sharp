// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3->A(m, n) = 9

int Ackkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Ackkerman(m - 1, 1);
    else return Ackkerman(m - 1, Ackkerman(m, n - 1));
}

int m = 2, n = 3;

Console.WriteLine("Функция Аккермана равна: {0}", Ackkerman(m, n));
// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

string Checking(string str)
{
    char[] ch = str.ToCharArray();
    Array.Reverse(ch);
    string newStr = new String(ch);
    return (str == newStr) ? "Да" : "Нет";
}

Console.Write("Введите пятизначное число: ");
string strNumber = Console.ReadLine();

Console.WriteLine(Checking(strNumber));
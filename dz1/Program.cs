﻿// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. 
// 14212 -> нет 
// 12821 -> да 
// 23432 -> да  

string Rever(string str)
{
    char[] result = new char[str.Length];
    for (int i = str.Length-1, j = 0; i >=0; i--,j++)
    {
        result[j] = str[i];
    }
    return new String(result);
}

Console.WriteLine("Введите число");
string str = Console.ReadLine() ?? "";
if (str.All(Char.IsDigit))
    if(str == Rever(str))
        Console.WriteLine("Является палиндромом");
    else
        Console.WriteLine("Неявляется палиндромом");
else
    Console.WriteLine("Ошибка!!! Введите только цифры");
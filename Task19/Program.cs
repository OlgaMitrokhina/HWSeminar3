// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine ("Введите пятизначное число и программа проверит, является ли оно палиндромом");
int n;
n = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(n);

if (n > 9999 && n < 100000)
{
if (stringNumber [0] == stringNumber [4] && stringNumber [1] == stringNumber [3])
Console.WriteLine ($"Данное число {n} - палиндром");
else
Console.WriteLine ($"Данное число {n} - не палиндром");
}
else
{
    Console.WriteLine ("Это не пятизначное число!");
}

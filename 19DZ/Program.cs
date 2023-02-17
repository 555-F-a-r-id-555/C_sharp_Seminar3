﻿// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> не
// 12821 -> да
// 23432 -> да


// Вариант 1 - при длине числа больше 5 или меньше 5;

void printRes(int num)
{
    Console.WriteLine($"{num} -> {newNum(num)}");
}

string newNum(int num)
{
    string num1 = $"{num}";
    int size = num1.Length;
    string newNum = "";
    for (int i = size - 1; i >= 0; i--) newNum += num1[i];
    return (num1 == newNum) ? "ДА" : "НЕТ";
}

// printRes(14212);
// printRes(12821);
// printRes(23432);
// printRes(121);
// printRes(1222222234);
// printRes(123454321);

// Вариант 2 - при длине числа равном 5;

void polindrom(int number1)
{
    if (1 <= (number1 / 10000) && (number1 / 10000) < 10)
    {
        int newNumber1 = 0;
        for (int i = 0; i < 5; i++)
        {
            newNumber1 += ((number1 / (int)Math.Pow(10, i)) % 10) * ((int)Math.Pow(10, 4 - i));
        }
        // Console.WriteLine($"{newNumber1}");
        string res = (number1 == newNumber1) ? "ДА" : "НЕТ";
        Console.WriteLine($"{number1} -> {res}");

    }
    else printRes(number1); // если число больше или меньше 5, смотреть выше ;
}

polindrom(14212);
polindrom(12821);
polindrom(23432);
//----------------
polindrom(121);
polindrom(123);
polindrom(1234554321);


// Вариант 3 - Самый простой, похож на 2 вариант;


string polindrom2(int number1)
{
    if (1 <= (number1 / 10000) && (number1 / 10000) < 10)
    {
        int newNumber1 = 0;
        for (int i = 0; i < 5; i++)
        {
            newNumber1 += ((number1 / (int)Math.Pow(10, i)) % 10) * ((int)Math.Pow(10, 4 - i));
        }
        return (number1 == newNumber1) ? "ДА" : "НЕТ";
    }
    return $"Длина числа не равна 5";
}

void printPolindrom2(int number1) =>
Console.WriteLine($"{number1} -> {polindrom2(number1)}");


printPolindrom2(14212);
printPolindrom2(12821);
printPolindrom2(23432);
//----------------
printPolindrom2(121);
printPolindrom2(123);
printPolindrom2(1234554321);


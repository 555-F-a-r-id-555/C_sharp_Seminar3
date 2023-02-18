// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


string palindrom(int number1)
{
    if (number1 >= 10000 && number1 < 100000)
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

void printPalindrom(int number1) =>
Console.WriteLine($"{number1} -> {palindrom(number1)}");


printPalindrom(14212);
printPalindrom(12821);
printPalindrom(23432);
//----------------
printPalindrom(121);
printPalindrom(123);
printPalindrom(1234554321);
// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


string polindrom(int number1)
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

void printPolindrom(int number1) =>
Console.WriteLine($"{number1} -> {polindrom(number1)}");


printPolindrom(14212);
printPolindrom(12821);
printPolindrom(23432);
//----------------
printPolindrom(121);
printPolindrom(123);
printPolindrom(1234554321);
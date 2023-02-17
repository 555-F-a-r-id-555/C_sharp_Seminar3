// Доп. задание
// Написать метод для разворота массива, 
// не используя память под дополнительный массив

int[] num = { 1, 2, 3, 4, 5 };
// Console.WriteLine($"{num.Length}");
void revers(int[] num)
{
    for (int i = num.Length - 1; i >= 0; i--)
    {
        Console.Write($"{num[i]} ");
    }
}

revers(num);
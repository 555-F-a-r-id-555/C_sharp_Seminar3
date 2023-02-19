// Доп. задание
// Написать метод для разворота массива, 
// не используя память под дополнительный массив

void revers(int[] num)
{
    int j = 0;
    int temp;
    for (int i = num.Length - 1; i > (num.Length - 1) / 2; i--)
    {
        temp = num[j];
        num[j] = num[i];
        num[i] = temp;
        //Console.Write($"{num[j]} ");
        j++;
    }
    foreach (int value in num) Console.Write($"{value} ");
    Console.WriteLine();
}

revers(new int[] { 1 });
revers(new int[] { 1, 2 });
revers(new int[] { 1, 2, 3 });
revers(new int[] { 1, 2, 3, 4 });
revers(new int[] { 1, 2, 3, 4, 5 });
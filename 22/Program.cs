// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

internal class Program
{
    private static void Main(string[] args)
    {
        void table(int a)
        {
            for (int i = 1; i < a; i++)
            {
                Console.Write($"{i * i}, ");
            }
            Console.Write($"{a * a} \n");
        }
        table(5);
        table(2);
    }
}


// Console.WriteLine($"34567 % 10 = {34567 % 10}");
// Console.WriteLine($"(34567 /10 )% 10 = {(34567 / 10) % 10}");
// Console.WriteLine($"(34567 / 100) % 10 = {(34567 / 100) % 10}");
// Console.WriteLine($"(34567 / 1000) % 10 = {(34567 / 1000) % 10}");

// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.


int x = Convert.ToInt16(Console.ReadLine());
int y = Convert.ToInt16(Console.ReadLine());


if (x > 0 && y > 0) Console.WriteLine($"1 четверть");
else if (x < 0 && y > 0) Console.WriteLine($"2 четверть");
else if (x < 0 && y < 0) Console.WriteLine($"3 четверть");
else if (x > 0 && y < 0) Console.WriteLine($"4 четверть");
else Console.WriteLine($"Ошибка ввода");
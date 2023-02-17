// Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
// 1 -> “x > 0 && y > 0” 
// 2 -> “x < 0 && y > 0” 
// 3 -> “x < 0 && y < 0” 
// 4 -> “x > 0 && y < 0”
// 5 -> “Неверно введен номер четверти”

int num = Convert.ToInt16(Console.ReadLine());

if (num == 1) Console.WriteLine($"{num} -> x > 0 && y > 0");
else if (num == 2) Console.WriteLine($"{num} -> x < 0 && y > 0");
else if (num == 3) Console.WriteLine($"{num} -> x < 0 && y < 0");
else if (num == 4) Console.WriteLine($"{num} -> x > 0 && y < 0");
else Console.WriteLine($"Неверно введен номер четверти");
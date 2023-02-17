// double a = 4;
// double b = 2;
// double c = Math.Pow(a, b);
// Console.WriteLine($"{c}");
// double d = Math.Sqrt(b);
// Console.WriteLine($"{d}");

// Задача 20: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

void my_function(int x1, int x2, int y1, int y2)
{
    double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    Console.WriteLine($"расстояние между точками -> {length:f2}");
}

my_function(3, 2, 6, 1);
my_function(7, 1, -5, -1);
// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


double length(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
}

void printRes(int x1, int y1, int z1, int x2, int y2, int z2) =>
Console.WriteLine($"{length(x1, y1, z1, x2, y2, z2):f2}");

printRes(3, 6, 8, 2, 1, -7);
printRes(7, -5, 0, 1, -1, 9);
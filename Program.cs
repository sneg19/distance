// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.Clear();
Console.WriteLine("Введите координату X1");
int X1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату Y1");
int Y1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату Z1");
int Z1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату X2");
int X2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату Y2");
int Y2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату Z2");
int Z2 = int.Parse(Console.ReadLine()!);

double distance = Math.Sqrt( Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2) + Math.Pow((Z2 - Z1), 2)); 
distance = Math.Round(distance, 2);
Console.WriteLine($"Растояние между введенными точками в 3D простанстве равно {distance}");
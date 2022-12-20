//Задача 21.Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 3D пространстве
Console.WriteLine("Введите хА: ");
int xA = int.Parse (Console.ReadLine());
Console.WriteLine("Введите yА: ");
int yA = int.Parse (Console.ReadLine());
Console.WriteLine("Введите zА: ");
int zA = int.Parse (Console.ReadLine());
Console.WriteLine("Введите хB: ");
int xB = int.Parse (Console.ReadLine());
Console.WriteLine("Введите yB: ");
int yB = int.Parse (Console.ReadLine());
Console.WriteLine("Введите zB: ");
int zB = int.Parse (Console.ReadLine());

double d = Math.Sqrt(Math.Pow(xA-xB, 2) + Math.Pow(yA-yB, 2) + Math.Pow(zA-zB, 2));

System.Console.WriteLine(Math.Round(d,2));
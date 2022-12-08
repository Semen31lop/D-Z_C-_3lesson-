//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.Write("Введите число x1: ");
int x1= int.Parse(Console.ReadLine()!);
Console.Write("Введите число x2: ");
int x2= int.Parse(Console.ReadLine()!);
Console.Write("Введите число y1: ");
int y1= int.Parse(Console.ReadLine()!);
Console.Write("Введите число y2: ");
int y2= int.Parse(Console.ReadLine()!);
Console.Write("Введите число z1: ");
int z1= int.Parse(Console.ReadLine()!);
Console.Write("Введите число z2: ");
int z2= int.Parse(Console.ReadLine()!);
int A=x1-x2; int B= y1-y2; int C=z1-z2;
double length = Math.Sqrt(A*A+B*B+C*C);
Console.WriteLine(length);




//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
int num = new Random().Next(10000, 99999);
int a1 = num / 100;
int a2 = num % 100;
if (a1 == a2)
{
    Console.WriteLine($"{num}-->да");
}
else
{
    Console.WriteLine($"{num}-->нет");
}
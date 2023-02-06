// Задача 10: 
// Напишите программу, которая принимает на вход
// трехзначное число и на выходе показывает вторую цифоу этого числа
// 456 -> 5
// 782 -> 2
// 918 -> 1

Console.Write("Введите число трёхзначное число: ");
int num = int.Parse(Console.ReadLine());
int result1 = (num / 10);
int result2 = (result1 % 10);
Console.WriteLine ($"{num} -> {result2}");
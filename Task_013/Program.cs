// Задача 13: 
// Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число трёхзначное число: ");
int num = int.Parse(Console.ReadLine());
int numA = num;
int result = 0;

while (num > 999)
{
    num = num / 10;
    result = num % 10;
}
if (num <= 99) // Если число меньше 100
{
    Console.WriteLine($"{num} -> третьей цифры нет");
}
else if (num <= 999) // Если число в диапазоне от 100 до 999
{
    result = num % 10;
    Console.WriteLine($"{numA} -> {result}");
}
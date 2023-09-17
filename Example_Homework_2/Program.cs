// Задача 2: Напишите программу, которая: 
// 1. на вход принимает два числа 
// 2. выдаёт, какое число большее, а какое меньшее.
// Примеры:
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Напишите 2 числа для сравнения:");
Console.WriteLine("Напишите свое первое число:");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите свое второе число:");
int numberTwo = Convert.ToInt32(Console.ReadLine());

if (numberOne > numberTwo)
{
    Console.WriteLine($"a = {numberOne}; b = {numberTwo} -> max = {numberOne}");
}
else
{
    Console.WriteLine($"a = {numberOne}; b = {numberTwo} -> max = {numberTwo}");
}
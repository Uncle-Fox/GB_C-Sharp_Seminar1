﻿// Задача 6: Напишите программу, которая 
// 1. на вход принимает число 
// 2. и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// Пример: 
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Давайте проверим ваше число на четность.");
Console.WriteLine("Введите свое число:");

int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine($"{number} -> да");
}
else
{
    Console.WriteLine($"{number} -> нет");
}
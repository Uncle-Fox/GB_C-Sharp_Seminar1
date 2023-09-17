// See https://aka.ms/new-console-template for more information
// Написать программу которая
// 1. Принимает 2 числа
// 2. Проверяет является ли первое число квадратом второго
// 3. Вывод

Console.WriteLine("Введите два числа. Программа посчитает является ли первое число квадратом второго");
Console.WriteLine("Введите первое число: ");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int SecondNumber = Convert.ToInt32(Console.ReadLine());

if (FirstNumber / SecondNumber == SecondNumber)
{
    Console.WriteLine($"A = {FirstNumber} B = {SecondNumber} -> Да");
}
else
{
    Console.WriteLine($"A = {FirstNumber} B = {SecondNumber} -> Нет");
}
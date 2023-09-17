// Задача 4: Напишите программу, которая:
// 1. принимает на вход три числа
// 2. и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Напишите любые 3 числа, а программа найдет среди них максимальное.");
Console.WriteLine("Напишите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите третье число: ");
int numberThree = Convert.ToInt32(Console.ReadLine());

if (numberOne > numberTwo && numberOne > numberThree)
{
    Console.WriteLine($"{numberOne} {numberTwo} {numberThree} -> {numberOne}");
}
else if (numberTwo > numberOne && numberTwo > numberThree)
{
    Console.WriteLine($"{numberOne} {numberTwo} {numberThree} -> {numberTwo}");
}
else
{
    Console.WriteLine($"{numberOne} {numberTwo} {numberThree} -> {numberThree}");
}
// Написать программу, которая на вход принимает число и выдает его квадрат
Console.Write("Введите число, которое умножится на себя ");
int MyNumber = Convert.ToInt32(Console.ReadLine());
int square = MyNumber * MyNumber;
Console.WriteLine(MyNumber + " -> " + square);
Console.WriteLine($"{MyNumber} -> {square}");


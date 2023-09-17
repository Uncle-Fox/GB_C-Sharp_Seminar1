// 7. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите свое трехзначное число, а мы покажем его последнее значение");
int myNumber = Convert.ToInt32(Console.ReadLine());

if (myNumber < 0)
{
    myNumber = -myNumber;
}

if (myNumber >= 100 && myNumber <= 999)
{
    int lastNumber = myNumber % 10;
    Console.WriteLine($"{myNumber} -> {lastNumber}");
}
else
{
    Console.WriteLine("Это не трехзначное число!");
}

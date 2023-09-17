// Напишите программу, которая выдает названия дня недели по заданному 
//номеру
Console.WriteLine("Введите порядковый день недели: ");
string DayOfTheWeek = Console.ReadLine();
if (DayOfTheWeek == "1")
{
    Console.WriteLine($"{DayOfTheWeek} -> Понедельник");
}
else if (DayOfTheWeek == "2")
{
    Console.WriteLine($"{DayOfTheWeek} -> Вторник");
}
else if (DayOfTheWeek == "3")
{
    Console.WriteLine($"{DayOfTheWeek} -> Среда");
}
else if (DayOfTheWeek == "4")
{
    Console.WriteLine($"{DayOfTheWeek} -> Четверг");
}
else if (DayOfTheWeek == "5")
{
    Console.WriteLine($"{DayOfTheWeek} -> Пятница");
}
else if (DayOfTheWeek == "6")
{
    Console.WriteLine($"{DayOfTheWeek} -> Суббота");
}
else if (DayOfTheWeek == "7")
{
    Console.WriteLine($"{DayOfTheWeek} -> Воскресенье");
}
else
{
    Console.WriteLine("Ошибка ввода");
}
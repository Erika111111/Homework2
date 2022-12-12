// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число: ");
string input = Console.ReadLine();
int number = Convert.ToInt32(input);
int result = ((number - ((number / 100) * 100) - (number % 10)) / 10);
Console.WriteLine($"{result}");

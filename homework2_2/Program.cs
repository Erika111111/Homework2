// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. //

Console.WriteLine("Введите число: ");
string input = Console.ReadLine();
int number = Convert.ToInt32(input);

if (number > 99)
Console.WriteLine(number.ToString()[2]);
else 
Console.WriteLine("Третьей цифры нет");


//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число: ");
string input = Console.ReadLine();
int number = Convert.ToInt32(input);

if(number < 6)
{
    Console.WriteLine("Будние дни");
}
if((number == 6)||(number == 7))
{
    Console.WriteLine("Выходной день");
}
else
{
    Console.WriteLine("не верно введено число");
}
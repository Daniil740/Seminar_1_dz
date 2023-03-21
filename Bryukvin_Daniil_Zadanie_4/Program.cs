//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int number3 = Convert.ToInt32(Console.ReadLine());
int numbermax = number1;
if (number2>number1)
{
    numbermax= number2;
}
if (number3>numbermax)
{
    numbermax=number3;
}
Console.WriteLine ($"максимальное={numbermax}");
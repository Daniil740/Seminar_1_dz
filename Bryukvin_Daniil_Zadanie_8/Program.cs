//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());
int res=2;

while(res<=number1)
{
    Console.WriteLine(res);
    res=res+2;
}
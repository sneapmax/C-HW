// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Первое задание");

Console.WriteLine("enter the first number");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("enter the second number");
int number2 = int.Parse(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine($"{number1} > {number2}");
}
    else 
{
    Console.WriteLine($"{number2} > {number1}");
}

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


Console.WriteLine("Второе задание");

Console.WriteLine("enter the first number");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("enter the second number");
int number2 = int.Parse(Console.ReadLine());

Console.WriteLine("enter the third number");
int number3 = int.Parse(Console.ReadLine());

int max = number1

if (max < number2)
{
    max = number2;
}
    else 
    if (max < number3)
{
     max = number3;
}
    else
{
     Console.WriteLine($"max number = {max}");
}    
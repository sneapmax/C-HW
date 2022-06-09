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
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("enter the second number");
int numberB = int.Parse(Console.ReadLine());

Console.WriteLine("enter the third number");
int numberC = int.Parse(Console.ReadLine());

int max = numberA;

if (max < numberB)
{
    max = numberB;
}
if (max < numberC)
{
    max = numberC;
}

Console.WriteLine($"max number = {max}");


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Третье задание");

Console.WriteLine("enter the number");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine($"число {number} четное");
}
    else 
{
    Console.WriteLine($"число {number} нечетное");
}    

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Четвертое задание");

Console.WriteLine("enter the number");
int N = int.Parse(Console.ReadLine());
int countN = 2;

while (countN <= N)
{
    Console.Write($"{countN} ");
    countN += 2;
}

Console.Write("the end))");
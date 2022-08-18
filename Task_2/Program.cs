/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 
*/

int a1 = 5;
int b1 = 7;
if (a1 > b1)
{
    Console.WriteLine("Первое число больше второго: " + (a1) + " > " +(b1));
}
else
{
    Console.WriteLine("Второе число больше первого: " + (a1) + " < " + (b1));
}


int a2 = 2;
int b2 = 10;
if (a2 > b2)
{
    Console.WriteLine("Первое число больше второго: " + (a2) + " > " +(b2));
}
else
{
    Console.WriteLine("Второе число больше первого: " + (a2) + " < " + (b2));
}


int a3 = -9;
int b3 = -3;
if (a3 > b3)
{
    Console.WriteLine("Первое число больше второго: " + (a3) + " > " +(b3));
}
else
{
    Console.WriteLine("Второе число больше первого: " + (a3) + " < " + (b3));
}

/*

Console.Write("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("Первое число больше второго: " + (a) + " > " +(b));
}
else if (a < b)
{
    Console.WriteLine("Второе число больше первого: " + (a) + " < " + (b));
}    
else
{
    Console.WriteLine("Первое число равно второму: " + (a) + " = " + (b));
}

*/
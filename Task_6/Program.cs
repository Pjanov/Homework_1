/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет */


int num1 = 4;
int num2 = num1 % 2;
if (num2 == 0)
{
    Console.WriteLine("Число: " + (num1) + " является четным!");
}
else
{
    Console.WriteLine("Число: " + (num1) + " является нечетным!");
}


int num3 = -3;
int num4 = num3 % 2;
if (num4 == 0)
{
    Console.WriteLine("Число: " + (num3) + " является четным!");
}
else
{
    Console.WriteLine("Число: " + (num3) + " является нечетным!");
}


int num5 = 7;
int num6 = num5 % 2;
if (num6 == 0)
{
    Console.WriteLine("Число: " + (num5) + " является четным!");
}
else
{
    Console.WriteLine("Число: " + (num5) + " является нечетным!");
}   


/*
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = a % 2;
if (b == 0)
{
    Console.WriteLine("Число: " + (a) + " является четным!");
}
else
{
    Console.WriteLine("Число: " + (a) + " является нечетным!");
}
*/
/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */


int a1 = 2;
int b1 = 3;
int c1 = 7;

int max1 = a1;

if (a1 > max1) max1 = a1;
if (b1 > max1) max1 = b1;
if (c1 > max1) max1 = c1;

Console.WriteLine("Максимальное число: " + "max = " + (max1));


int a2 = 44;
int b2 = 5;
int c2 = 78;

int max2 = a2;

if (a2 > max2) max2 = a2;
if (b2 > max2) max2 = b2;
if (c2 > max2) max2 = c2;

Console.WriteLine("Максимальное число: " + "max = " + (max2));


int a3 = 22;
int b3 = 3;
int c3 = 9;

int max3 = a3;

if (a3 > max3) max3 = a3;
if (b3 > max3) max3 = b3;
if (c3 > max3) max3 = c3;

Console.WriteLine("Максимальное число: " + "max = " + (max3));


/*
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третие число: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine("Максимальное число: " + "max = " + (max));
*/
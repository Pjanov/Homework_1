/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе
 показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */



int num1 = 5;
int i1 = 2;
Console.WriteLine("Вывод четных чисел от 1 до " + (num1) + ":");

while (i1 < num1-1)
{
    Console.Write((i1) + ", ");
    i1 = i1 + 2;
}
Console.WriteLine((i1) + ". ");




int num2 = 8;
int i2 = 2;
Console.WriteLine("Вывод четных чисел от 1 до " + (num2) + ":");

while (i2 < num2-1)
{
    Console.Write((i2) + ", ");
    i2 = i2 + 2;
}
Console.WriteLine((i2) + ". ");


/*              //Всамой программе применил  операторы if и else, что бы не вводили меньше единицы !
Console.Write("Введите положительное целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 2;
Console.WriteLine("Вывод четных чисел от 1 до " + (num) + ":");
if (num <= 1)
{
    Console.WriteLine("Число должно быть БОЛЬШЕ единийы !!!");
}
else
{
   while (i < num - 1)
{
    Console.Write((i) + ", ");
    i = i + 2;
}
Console.Write((i) + ". "); 
}
*/
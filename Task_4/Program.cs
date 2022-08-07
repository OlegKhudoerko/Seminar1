/* Урок 1. Знакомство с языком программирования С#

Задача 4: Напишите программу, которая принимает на вход 
три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите первое число: ");
int number_a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number_b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int number_c = Convert.ToInt32(Console.ReadLine());

if (number_a > number_b && number_a > number_c)
{
    Console.WriteLine(number_a + ", " + number_b + ", " + number_c + ", " + " ->  " + number_a);
}
else
{
    if (number_b > number_a && number_b > number_c)
    {
        Console.WriteLine(number_a + ", " + number_b + ", " + number_c + ", " + " -> " + number_b);
    }
    else
    {
        Console.WriteLine(number_a + ", " + number_b + ", " + number_c + ", " + " -> " + number_c);
    }
}

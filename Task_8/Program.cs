/* Урок 1. Знакомство с языком программирования С#

Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8

*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int counter = 2;
if (number > 1) //Избегаем кофликт, значение на входе не соответствующее условию задачи
{
    Console.Write($"{number} -> ");
    while (counter + 2 <= number)
    {
        Console.Write($"{counter}, ");
        counter = counter + 2;
    }
      Console.Write(counter); //Избавляемся от запятой в цикле, последнее значение счетика
}
else Console.Write(number + " -> -1 (Ваше число меньше минимального положительного целого четного числа)");
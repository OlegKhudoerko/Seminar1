/*Урок 1. Знакомство с языком программирования С#

**Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

*/

Console.WriteLine("Введите число а: ");
int number_a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b: ");
int number_b = Convert.ToInt32(Console.ReadLine());

if (number_a > number_b) Console.WriteLine($"a = {number_a}; b = {number_b} -> max = {number_a}");

else Console.WriteLine($"a = {number_a}; b = {number_b} -> max = {number_b}");

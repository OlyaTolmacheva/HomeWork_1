﻿// Домашнее задание к Семинару 1 - Знакомство с языками программирования

// Задача 2.
// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
// Например:
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Введите число");
// int number1=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число");
// int number2=Convert.ToInt32(Console.ReadLine());
// if(number1>number2)
// {
//     Console.WriteLine(number1);
// }
// else
// {
//     Console.WriteLine(number2);
// }

// Задача 4. Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.
// Например:
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("Введите число");
// int number1=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число");
// int number2=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число");
// int number3=Convert.ToInt32(Console.ReadLine());
// int max= number1;
// if(number2>max)
// {
//     max= number2;
// }
// if(number3>max)
// {
//     Console.WriteLine(number3);
// }
// else
// {
//     Console.WriteLine(max);
// }

// Задача 6. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
// (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.WriteLine("Введите число");
// int number=Convert.ToInt32(Console.ReadLine());

// int ost= number%2;

// if(ost==0)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }

// Задача 8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");
int number=Convert.ToInt32(Console.ReadLine());

int numberChet= 2;

while(numberChet<=number)
{
    Console.WriteLine(numberChet);
    numberChet=numberChet+2;
}
﻿// Задача 1: Задайте значения M и N. Напишите программу, которая выведет
//  все натуральные числа в промежутке от M до N. Использовать рекурсию,
//   не использовать циклы.

Console.Write("Введите значение M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int N= Convert.ToInt32(Console.ReadLine());


void PrintNumbers(int M, int N)
{
if(M > N) return;
Console.Write(M + " ");
PrintNumbers(M + 1, N);
}

PrintNumbers(M, N);
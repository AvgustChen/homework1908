﻿// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

void ShowNumsNM(int n, int m)
{
    if (m > n)
    {
        int temp = n;
        n = m;
        m = temp;
    }
    if (n != m) ShowNumsNM(n - 1, m);
    Console.Write(n + " ");
}
Console.Write("Input number M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number N: ");
int numN = Convert.ToInt32(Console.ReadLine());

ShowNumsNM(numN, numM);
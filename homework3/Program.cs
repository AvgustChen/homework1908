﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

int A(int n, int m)
{
    if (n == 0) return m + 1;
    else if ((n != 0) && (m == 0)) return A(n - 1, 1);
    else return A(n - 1, A(n, m - 1));
}
int a = A(3, 2);
Console.WriteLine(a);
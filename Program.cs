// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.

// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30


int Function(int m, int n)
{
    if (m == n)
    {
        return n;
    }
    return m + Function(m + 1, n);
}
int a = Function(1, 15);
System.Console.WriteLine(a);
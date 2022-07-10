// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


void SumNums(int m, int n, int sum)
{
    sum = sum + n;
    if (n <= m)
    {
       Console.Write($"Sum of elements between M and N = {sum} ");
       return; 
    }
    SumNums(m, n-1, sum);
}

Console.WriteLine("Enter number M" );
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number N" );
int n = Convert.ToInt32(Console.ReadLine());

SumNums(m,n,0);


/*
// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать кол-во его цифр.
// 453 -> 3     45 -> 2

int QuantityOfNumber (int num)
{
    if (num / 10 == 0)
    return 1;
    return 1 + QuantityOfNumber(num / 10);
}

Console.Write("Input number " );
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Number of digits is " + QuantityOfNumber (num));
*/
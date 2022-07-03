/*
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] CreateRandomTwoDemArray(int a, int b, int min, int max)
{
    double[,] newMatrix = new double[a,b];

    for(int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            newMatrix[i,j] = Math.Round(new Random().Next(5,5) + new Random().NextDouble(),1);
            Console.Write(newMatrix[i,j] + " ");
        }
        Console.WriteLine();

    }
    
    return newMatrix;
}
double[,] array = CreateRandomTwoDemArray(5,5,1,9);
*/
/*
//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

int [,] CreateRandomTwoDemArray(int a, int b, int min, int max)
{
    int[,] newMatrix = new int[a,b];

    for(int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            newMatrix[i,j] = new Random().Next(min, max + 1);
          
        }
       
    }
    
    return newMatrix;
}

void SumOfAverage(int [,] array)
{
    
    for(int j = 0; j < array.GetLength(1); j++)
    
    {
    
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i,j];

        }
        double average = sum / array.GetLength(0);
        Console.Write(average + " ");
    }    

}

int[,] myArray = CreateRandomTwoDemArray(4,3,1,5);
Print (myArray);
SumOfAverage(myArray);

void Print (int [,] array2)
{
     for(int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            Console.Write (array2[i,j] + " ");

        }
        
        Console.WriteLine ();
    }    

}

*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
//в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write($"Введите число количество строк: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите число количество столбцов: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите min число: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите max число: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] CreateRandomTwoDemArray(int a, int b, int min, int max)
{
    int[,] newMatrix = new int[a,b];

    for(int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            newMatrix[i,j] = new Random().Next(min, max + 1);
        }
       Console.WriteLine();
    }
    
    return newMatrix;
}

int[,] newMatrix = CreateRandomTwoDemArray(a, b, min, max);

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

void ShowElement (int[,] newMatrix, int m, int n)
{
    int result = 0;
    if(m < newMatrix.GetLength(0) && n < newMatrix.GetLength(1))
    {
        result = result + newMatrix[m,n];
        Console.Write("Число " + result);
    }
    else Console.Write("Такого числа нет");

}

ShowElement (newMatrix,m,n);
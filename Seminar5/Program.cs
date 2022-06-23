/*
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2

int[] CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max + 1);
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();

    return newArray;
}

int[] CountDigit(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = array[i];
    }
    return array;
}
 //int[] array1 = CreateRandomArray(5,100,999);

int Quantity (int[] array)
{
    int quantity = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) quantity++;
    }
    return quantity;
}

int[] array2 = CreateRandomArray(5, 100, 999);
int result = Quantity(array2);
Console.WriteLine("Количество четных чисел в массиве " + result);
*/
/*
// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях. [3, 7, 23, 12] -> 19 [-4, -6, 89, 6] -> 0


int[] CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max + 1);
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();

    return newArray;
}
int FindSum(int[] array )
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 !=0) sum += array[i];
    }
    return sum;
}

int[] myArray = CreateRandomArray(5,-9,9);

Console.WriteLine("Sum of numbers is " + FindSum(myArray));
*/

// Задайте массив вещественных(дробных, см. Random().NextDouble()) чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.[3 7 22 2 78] -> 76

double[] arrayNumbers = new double[20];
for(int i = 1; i < arrayNumbers.Length; i++)
{
    arrayNumbers[i] = Math.Round(new Random().Next(8, 20) + new Random().NextDouble(),1);
    Console.Write(arrayNumbers[i] + " ");
}
double maxNumber = arrayNumbers[0];
double minNumber = arrayNumbers[0];
for(int i = 1; i < arrayNumbers.Length; i++)
{
    if (maxNumber < arrayNumbers[i])
    {
        maxNumber = arrayNumbers[i];
    }
    if (minNumber > arrayNumbers[i])
    {
        minNumber = arrayNumbers[i];
    }
}
double difference = maxNumber - minNumber;
Console.WriteLine($"Разница между максимальным и минимальным элементом  {difference}");
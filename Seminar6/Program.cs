
//Напишите программу, которая будет создавать копию заданного массива с 
//помощью поэлементного копирования.

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

int[] CopyArray (int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = array[i];
    }
    return array;
}
int[] array1 = CreateRandomArray(12, 1, 9);

int[] array2 = CopyArray(array1);

for(int i = 0; i < array2.Length; i++)
{
    Console.Write(array2[i]+ " ");
}

/*
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь. 0, 7, 8, -2, -2 -> 2 1, -7, 567, 89, 223-> 3

Console.Write($"Введите число количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] massiveNumbers = new int[m];

void InputNumbers(int m)
{
    for(int i = 0; i < m; i++)
    {
        Console.Write($"Введите {i+1} число: ");
        massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int Comparision(int[] massiveNumbers)
{
    int count = 0;
    for(int i = 0; i < massiveNumbers.Length; i++)
    {
        if (massiveNumbers[i] > 0) count+=1;
    }
    return count;
}
InputNumbers(m);
Console.Write($"Введено чисел больше 0: {Comparision(massiveNumbers)} ");
*/
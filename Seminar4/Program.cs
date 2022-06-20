// Задача 25: Напишите программу, которая принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

/*
int Exponentiation(int numberA, int numberB)
{
    int result = 1;
    for (int i = 1; i <= numberB; i++)
    {
        result = result * numberA;
    }
    
    return result;
}

Console.WriteLine("Input number A:" );
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number B:" );
int numberB = Convert.ToInt32(Console.ReadLine());

int exponentiation = Exponentiation(numberA, numberB);
Console.WriteLine("Ответ: " + exponentiation);
*/

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 3, 44, 3 -> [1, 2, 5, 7, 19, 3, 44, 3]

/*
int size = 8;
int[] array = new int [size];

for(int i = 0; i < size; i++)
{
    array[i] = new Random().Next(0,9);
}
for(int i=0; i < size; i++)
{
    Console.Write(array[i] + " ");
}
*/

int size = 8;
int[] array = new int [size];

for(int i = 0; i < size; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
for(int i =0; i < size; i++)
{
    Console.Write(array[i]+" ");
}


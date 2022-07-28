// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна которых меньше или равна 3 символа. 
string[] array1 = new string[5] {"123", "23", "hello", "world", "yes"};
string[] array2 = new string[array1.Length];
int count = 0;
void SecondArrayCountElements(string[] array1, string[] array2)
{
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArrayCountElements(array1, array2);
PrintArray(array2); 
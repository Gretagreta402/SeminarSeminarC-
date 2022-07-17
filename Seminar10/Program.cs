// Задача 1: Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.
// Пример: { "qwe", "wer", "ert", "rty", "tyu"} -> 1


int CountWordsVowel(string[] array, char a, char b, char c, char d, char m, char n)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i][0] == a || array[i][0] == b || array[i][0] == c || array[i][0] == d || array[i][0] == m || array[i][0] == n )
            count ++;
    }
    return count;

}
char a = 'A';
char b = 'E';
char c = 'I';
char d = 'O';
char m = 'U';
char n = 'Y';

string [] array1 = {"January", "February", "March", "April", "May", "August", "October"};
Console.WriteLine(CountWordsVowel(array1, a, b, c, d, m, n));


/*
// Задача 2: Задайте массив строк. Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно.
// Пример: { "qwe", "wer", "ert", "rty", "tyu", "yui"} -> { "qwewer", "ertrty", "tyuyui"}

string[] CreateStringArray(int size)
{
    string[] words = new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} word: ");
        words[i] = Console.ReadLine();
    }

    return words;
}

void ShowArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i] + " ");
            Console.WriteLine();
    }
}

string[] WordMerging(string[] array)
{
    int size = array.Length/2;
    if(array.Length % 2 != 0) size += 1;
    string[] result = new string[size];
    int j = 0;
    for(int i = 0; i < array.Length/2; i++, j+=2)
    {
        result[i] = array[j] + array[j + 1]; 
    } 
    if(array.Length % 2 != 0) 
        result[size-1] = array[array.Length-1];
    return result;
}
Console.Write("Input number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] words = CreateStringArray(size);
ShowArray(WordMerging(words));
*/

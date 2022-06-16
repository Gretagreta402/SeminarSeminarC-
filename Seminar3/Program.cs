
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*
void Quad(int num)
{
    int current = 1;
    while (current <= num)
    {
        Console.Write((current * current * current) + " ");
        current++;
    }
}
Console.WriteLine("Input integer number");
int num = Convert.ToInt32(Console.ReadLine());

Quad(num);
*/

// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.

/*
double FindDistance(double xA, double yA, double xB, double yB, double zA, double zB)

{
  return Math.Sqrt(Math.Pow((xB-xA),2) + Math.Pow((yB-yA),2) + Math.Pow((zB-zA),2));
   
}

Console.Write("Введите координаты xA: ");
double xA = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты yA: ");
double yA = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты zA: ");
double zA = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты xB: ");
double xB = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты yB: ");
double yB = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты zB: ");
double zB = Convert.ToDouble(Console.ReadLine());

double result = FindDistance(xA, yA, xB, yB, zA, zB);
Console.WriteLine($" Расстояние между точками  {Math.Round(result,2)}");

*/
// Напишите программу, которая принимает 
//на вход пятизначное число и проверяет, является ли оно палиндромом.

void ChekingNumber(string number) {

if (number[0] ==  number[4] || number[1] == number[3])
{
    Console.WriteLine("Это число палиндром");
}
else Console.WriteLine("Это число не палиндром");
}
Console.WriteLine ("Введите пятизначное число");
string number = Console.ReadLine();

ChekingNumber(number);
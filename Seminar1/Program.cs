
/*
int num, result;

Console.WriteLine("Input integer number: ");
num = Convert.ToInt32(Console.ReadLine());

 result = num * num;

 Console.WriteLine("result is "  + result);

*/

/*
int num1, num2, quad;
Console.WriteLine("Input first integer number: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second integer number: ");
num2 = Convert.ToInt32(Console.ReadLine());

quad = num2 * num2;
if(num1 == quad)
{
    Console.WriteLine ("True");
}
else
{
    Console.WriteLine("False");
}
*/

/*
int num;

Console.WriteLine("Input integer number: ");
num = Convert.ToInt32(Console.ReadLine());

int current = num * (-1);

while (current <= num)
{
    Console.Write(current + " ");
    current = current + 1;
}
*/

/*
int num1, num2;
Console.WriteLine("Input first integer number: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second integer number: ");
num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("num1 - большее число");
}

else 
{
    Console.WriteLine("num2 - большее число");
}
*/

/*
int a, b, c;

Console.WriteLine("Input first integer number: ");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second integer number: ");
b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input third integer number: ");
c = Convert.ToInt32(Console.ReadLine());
 int max = a;


if (b > max) max = b;
if (c > max) max = c;
Console.Write(" max = ");
Console.WriteLine(max);
*/

/*
int num1;
Console.WriteLine("Input integer number:  ");
num1 = Convert.ToInt32(Console.ReadLine());

if (num1 % 2 == 0)
{
    Console.WriteLine("True");
}

else
{
    Console.WriteLine("False");
}
*/

int num;
Console.WriteLine("Input integer number:  ");
num = Convert.ToInt32(Console.ReadLine());

int current = 1;

while (current <= num)

{
Console.Write(current +" ");
current ++;
}


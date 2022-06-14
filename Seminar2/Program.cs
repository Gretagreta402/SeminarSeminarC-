/*
int CutNumber()
{
    int num = new Random().Next(100,1000);
    Console.WriteLine($"Current number is {num}");
   
    int sot = num / 10;
    
    int result = sot % 10;
    return result;
}
int b = CutNumber();
Console.WriteLine(b);
*/

/*
Console.WriteLine("Input integer number");
int anyNumber = Convert.ToInt32(Console.ReadLine());

string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2)
{
    Console.WriteLine (" third digit is " + anyNumberText[2]);
}

else 
{
Console.WriteLine (" third digit is not exist ");
}
*/

Console.WriteLine("Input integer number one to seven");
int DayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek(int DayNumber) {

if (DayNumber == 6 || DayNumber == 7)
{
    Console.WriteLine("This is day off");
}
else if (DayNumber >= 1 && DayNumber <= 5)
Console.WriteLine("This is work day");
}
CheckingTheDayOfTheWeek(DayNumber);
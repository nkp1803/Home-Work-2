// Задача 1: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.
System.Console.Write("Введите трёхзначное число : ");
string paramString = Console.ReadLine();
int paramInt = int.Parse(paramString);

if (paramInt >999 || paramInt<100)
{
    System.Console.WriteLine("Введене не верное число");
}
else 
{
    System.Console.WriteLine(" Вторая цифра : " + (paramInt % 100)/10);
}
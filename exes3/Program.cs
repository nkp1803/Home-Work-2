// Задача 3: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
int prompt(string message)
{
    System.Console.Write(message);
    string number = Console.ReadLine();
    int numberInt = int.Parse(number);
    return numberInt;
}
int numberInt = prompt("Введите число : ");

if (numberInt < 100) System.Console.WriteLine(("Третьей цыфры нет"));
else
{
    while (numberInt > 999)
    {
        numberInt = numberInt / 10;
    }
    numberInt = numberInt % 10;
    System.Console.WriteLine(("Трутья цыфра числа" + numberInt));
}

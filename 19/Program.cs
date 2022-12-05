/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

int GetNumber(string message)
{
    int result = 0;
    bool isCorrect = false;

    while(!isCorrect)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Ввели не число. Введите число");
        }
    }
    return result;
}
int x = GetNumber(" Введите число ");
int oldValue = x;
int newValue = 0;
while (x > 0)
{
    int dig = x % 10;
    newValue = newValue * 10 + dig;
    x = x / 10;
}

if(newValue == oldValue)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}

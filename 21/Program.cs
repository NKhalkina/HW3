//Задача 21. напишите программу, которая на вход принимает координаты двух точек и находит рассояние между ними в 3D впространстве 
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

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
            Console.WriteLine("Ввели не число или 0. Введите корректное число");
        }
    }
    return result;
}

int x1 = GetNumber("Введите x1");
int y1 = GetNumber("Введите y1");
int z1 = GetNumber("Введите z1");
int x2 = GetNumber("Введите Х2");
int y2 = GetNumber("Введите y2");
int z2 = GetNumber("Введите z2");

double FirstSum = Math.Pow((x1 - x2), 2);
double SecondSum = Math.Pow((y1 - y2), 2);
double ThirdSum = Math.Pow((z1 - z2), 2);
double result = Math.Sqrt(FirstSum + SecondSum + ThirdSum);

Console.WriteLine(result);

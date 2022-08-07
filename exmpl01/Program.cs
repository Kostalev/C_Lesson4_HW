// Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


double GetInput(string input)
{
    Console.Write(input);
    return Convert.ToInt32(Console.ReadLine());
}

double GetExp(double a, double b)
{
    double result = 1;
    for (double i = 1; i <= b; i++)
    {
        result = result * a;
    }
    return result;
}

string msg = "Если первое число возвести в степень, равную второму числу, получим результат: ";

double a = GetInput("Введите первое число: ");
double b = GetInput("Введите второе число: ");
double exp = GetExp(a, b);

Console.WriteLine(msg + exp);
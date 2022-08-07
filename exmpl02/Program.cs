// Задача 27: Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.

int GetInput(string input)
{
    Console.Write(input);
    return Convert.ToInt32(Console.ReadLine());
}

int GetSumm(int input)
{
    int count = Convert.ToString(input).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < count; i++)
    {
        advance = input - input % 10;
        result = result + (input - advance);
        input = input / 10;
    }
    return result;
}

int inpt = GetInput("Введите число: ");
int summ = GetSumm(inpt);

Console.WriteLine("Сумма всех цифр во введенном числе: " + summ);
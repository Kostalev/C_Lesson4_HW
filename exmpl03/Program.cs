// Задача 29: Напишите метод(ы), который задаёт массив из 8 элементов и выводит их на экран.


void Print(int[] array) // Метод печати
{
    int size = array.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

string GetData(string title) // Метод считывания данных
{
    Console.Write(title);
    return Console.ReadLine()!;
}

int CountSynbol(string s, char c) // Метод подсчета символов
{
    int count = 0;
    int length = s.Length;
    for (int i = 0; i < length; i++)
    {
        if (s[i] == c) count++;
    }
    return count;
}

int IndexOf(string s, char c) // Метод поиска (ищем позицию запятой, чтобы разделить строку на нужные числа)
{
    int length = s.Length;
    //int pos = -1;
    for (int i = 0; i < length; i++)
    {
        if (s[i] == c)
        {
            return i;
            //pos = i;
            //break;
        }
    }
    //return pos;
    return -1;
}  // алгоритм линейного поиска

string Substring(string s, int position) // Метод выделения подстроки с определенного элемента (для выделения из строки нужных чисел)
{
    string res = String.Empty;

    int size = s.Length;
    for (int i = position; i < size; i++)
    {
        res += $"{s[i]}";
    }

    return res;
}

string SubstringLength(string s, int position, int length) // // Метод выделения из подстроки определенного элемента
{
    string res = String.Empty;

    int size = s.Length;
    for (int i = position; i < position + length; i++)
    {
        res += $"{s[i]}";
    }

    return res;
}

int[] Parse(string s) // Метод получения числа из строки по разделителю
{
    int[] result = new int[CountSynbol(s, ',') + 1];
    s += ","; // Искусственно добавили, чтобы не получить зацикливание
    int index = 0;

    while (s.Length != 0)
    {
        int posSeparator = IndexOf(s, ',');
        //System.Console.WriteLine($"pos {posSeparator}");
        string need = SubstringLength(s, 0, posSeparator);
        //System.Console.WriteLine($"need = {need}");
        string o = Substring(s, posSeparator + 1);

        //System.Console.WriteLine($"o    = {o}");
        //Console.ReadLine();
        s = o;
        result[index] = Convert.ToInt32(need);
        index++;
    }

    return result;
}

string str = GetData("Введите числа через запятую: ");
int[] inArr = Parse(str);
Console.Write("Получен массив: ");
Print(inArr);


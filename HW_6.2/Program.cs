// ДЗ 6.2  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Инициализация программы");

string linesForm = "Заданы 2 прямых: \ny = k1 * x + b1 \ny = k2 * x + b2";
Console.WriteLine(linesForm);
int b1 = ReadInt("b1");
int k1 = ReadInt("k1");
int b2 = ReadInt("b2");
int k2 = ReadInt("k2");
getCrossLines(b1, k1, b2, k2);

int ReadInt(string argName)
{
    Console.Write($"Введите {argName}: ");
    
    int number = 0;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Вы ввели не число! Введите число!");
    }

    return number;
}

void getCrossLines(int b1, int k1, int b2, int k2)
{
    if ( k1 != k2 )
    {
        double x = (double) (b2 - b1) / (k1 - k2);
        double y = (double) k1 * x + b1;
        Console.WriteLine($"Точка пересечения в заданных коордитнатах \nx = {x} y = {y}");
    }
    else   
    {
        Console.WriteLine("прямые совпадают или параллельны");
    }
}

Console.WriteLine("Программа завершила работу");

// ДЗ 6.1 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Инициализация программы");
int leng = ReadInt("количество чисел");
int [] array = new int[leng];
array = getArray(array);
Console.WriteLine(string.Join(", ", array));
checkResult(array);

int ReadInt(string argumrntName)
{
    Console.Write($"Введите {argumrntName}: ");
    
    int number = 0;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Вы ввели не число! Введите число!");
    }

    return number;
}

int[] getArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = ReadInt($"number {i+1} ");
    }

    return array;
}

void checkResult(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count +=1;
        }
    }
    Console.WriteLine($"Количество чисел больше 0 = {count}");
}
Console.WriteLine("Программа завершила работу");

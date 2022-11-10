start();

void start()
{
    while (true)
    {
        Console.ReadLine();
        Console.Clear();
        System.Console.WriteLine("41) Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь");
        System.Console.WriteLine("43) Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");
        System.Console.WriteLine("0) End");

        int NumTask = NumEnter("Номер задачи");

        switch (NumTask)
        {
            case 0: return; break;
            case 41: Separator(); break;
            case 43: PointsInterection(); break;

        }
    }
}


int NumEnter(string str)
{
    System.Console.WriteLine(str);
    int num = int.Parse(Console.ReadLine());
    return num;
}

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

void Separator()
{
    System.Console.WriteLine("Введите числа через пробел");
    string str = Console.ReadLine();

    var arrStr = str.Split(" ");

    int[] arr = Array.ConvertAll(arrStr, int.Parse);
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }

    Console.WriteLine($"Количество чисел больше нуля {count} ");
}


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
void PointsInterection()
{
    Console.WriteLine("Значение В1");
    double B1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Значение K1");
    double K1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Значение В2");
    double B2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Значение K2");
    double K2 = double.Parse(Console.ReadLine());

    double X = (B1 - B2) / (K2 - K1);
    double Y = K2 * X + B2;

    Console.WriteLine($"Точка пересечения двух прямых X: {X}; Y: {Y}");
}
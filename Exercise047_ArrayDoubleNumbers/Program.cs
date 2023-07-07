Console.Clear();
//Определение параметров массива
int rows = GetNumberFromUser("Введите количество строк массива: ", "Ошибка ввода");
int columns = GetNumberFromUser("Введите количество столбцов массива: ", "Ошибка ввода");

//Генерация вещественного массива
double[,] array = GetArray(rows, columns, 1, 10);

//Вывод созданного массива
PrintArray(array);



//Метод вывода сгенерированного массива
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

//Метод генерации массива с заданными параметрами
double[,] GetArray(double m, double n, int minValue, int maxValue)
{
    double[,] result = new double[(int)m, (int)n];
    Random random = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = Math.Round(new Random().NextDouble() * (maxValue - minValue) + minValue, 2);
        }
    }

    return result;
}

//Метод считывания введеного числа или вывод сообщения об ошибке
int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userNumber))
            return userNumber;

        Console.WriteLine(errorMessage);
    }
}

Console.Clear();
//Определение параметров массива
int rows = GetNumberFromUser("Введите количество строк массива: ", "Ошибка ввода");
int columns = GetNumberFromUser("Введите количество столбцов массива: ", "Ошибка ввода");

//Генерация целочисленного массива
int[,] array = GetArray(rows, columns, 1, 10);

//Вывод созданного массива
PrintArray(array);

//Вычисление и вывод среднего арифметического элементов в стобцах
AverageArrayColumns(array);

void AverageArrayColumns(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int count = 0;
        int sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
            count++;
        }
        double average = (double)sum / count;
        Console.WriteLine($"Среднее арифметическое столбца {j} = {average}");
    }
}
//Метод вывода сгенерированного массива
void PrintArray(int[,] array)
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
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    Random random = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = random.Next(minValue, maxValue + 1);
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



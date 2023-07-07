Console.Clear();
//Определение параметров массива
int rows = GetNumberFromUser("Введите количество строк массива: ", "Ошибка ввода");
int columns = GetNumberFromUser("Введите количество столбцов массива: ", "Ошибка ввода");

//Генерация целочисленного массива
int[,] array = GetArray(rows, columns, 1, 10);


//Вывод созданного массива
PrintArray(array);

//Ввведение параметров искомого элемента
int rowIndex = GetNumberFromUser("Введите искомую строку: ", "Ошибка ввода");
int columnIndex = GetNumberFromUser("Введите искомый столбец: ", "Ошибка ввода");

//Вывод искомого числа или сообщения об ошибке
SearchNumber(rowIndex, columnIndex);



//Метод поиска числа в массиве
void SearchNumber(int i, int j)
{
    if (i >= 0 && i < array.GetLength(0) && j >= 0 && j < array.GetLength(1))
    {
        int element = array[i, j]; // Получение значения элемента
        Console.WriteLine("Значение элемента: " + element);
    }
    else
    {
        Console.WriteLine("Такого элемента нет.");
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
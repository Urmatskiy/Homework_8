// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] CreateMassive(int row, int column, int start, int end)
{
    int[,] arr = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = new Random().Next(start, end + 1);
        }
    }
    return arr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FindLowestSumOfRow(int[,] arr)
{
    int sum = 0;
    int result = 0;
    int row = -1;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
        if (sum > result)
        {
            result = sum;
            row = i;
        } 
        sum = 0;
    }
    Console.WriteLine($"Наибольшая сумма чисел находится в строке под номером {row}");
}

int rows = EnterData("Введите количество строк: ");
int columns = EnterData("Введите количество столбцов: ");
int[,] array = CreateMassive(rows, columns, 0, 9);
PrintArray(array);
Console.WriteLine();
FindLowestSumOfRow(array);
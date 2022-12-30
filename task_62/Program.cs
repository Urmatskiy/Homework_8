// Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] CreateMassive(int row, int column, int start, int end)
{
    int[,] arr = new int[row, column];
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

void FillArray(int[,] arr)
{
    int temp = 1;
    int i = 0;
    int j = 0;
    for (int k = 0; k < arr.GetLength(0) * arr.GetLength(1); k++)
    {
        arr[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < arr.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= arr.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > arr.GetLength(1) - 1)
            j--;
        else
            i--;
    }
}

int rows = 4;
int columns = 4;
int[,] array = CreateMassive(rows, columns, 0, 9);
PrintArray(array);
Console.WriteLine();
FillArray(array);
PrintArray(array);
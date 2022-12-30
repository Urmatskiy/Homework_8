// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,,] CreateMassive(int a1, int a2, int a3, int start, int end)
{
    int[,,] array = new int[a1, a2, a3];
    for (int i = 0; i < a1; i++)
    {
        for (int j = 0; j < a2; j++)
        {
            for (int k = 0; k < a3; k++)
            {
                array[i, j, k] = new Random().Next(start, end + 1);
            }
        }
    }
    return array;
}

void PrintArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.WriteLine($"{arr[i, j, k]} ({i}, {j}, {k})");
            }
        }
    }
}

int a = EnterData("Введите первый параметр: ");
int b = EnterData("Введите второй параметр: ");
int c = EnterData("Введите третий параметр: ");
int[,,] array = CreateMassive(a, b, c, 10, 999);
PrintArray(array);




// Задача 49: Задайте двумерный массив. Найдите элементы, у 
// которых оба индекса чётные, и замените эти элементы на их 
// квадраты.
// Например, изначально массив                 Новый массив будет выглядеть 
// выглядел вот так:                           вот так:
// 1 4 7 2                                     1 4 49 2
// 5 9 2 3                                     5 81 2 9
// 8 4 2 4                                     64 4 4 4


int[,] GetArray(int m, int n)
{
    int[,] numbers = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            numbers[i, j] = i + j;
        }
    }
    return numbers;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            System.Console.Write(inArray[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[,] NewArray(int[,] array)
{
    int[,] numbers = array;
    for (int i = 0; i < numbers.GetLength(0); i += 2)
    {
        // if (i % 2 = 0)
        // {
        for (int j = 0; j < numbers.GetLength(1); j += 2)
        {
            // if (j % 2 = 0) 
            numbers[i, j] = Convert.ToInt32(Math.Pow(numbers[i, j], 2));
        }
        // }
    }
    return numbers;
}

void PrintNewArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            System.Console.Write(inArray[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

Console.Clear();
System.Console.WriteLine("введите количество строк: ");
int row = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("введите количество столбцов: ");
int col = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(row, col);
PrintArray(array);
System.Console.WriteLine();
int[,] result = NewArray(array);
PrintNewArray(array);
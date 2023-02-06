// Задача 46: Задайте двумерный массив размером m×n, 
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1


int[,] GetArray(int m, int n)
{
    int[,] numbers = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            numbers[i, j] = new Random().Next(int.MinValue, int.MaxValue);
        }
    }
    return numbers;
}

int[,] PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            System.Console.Write(inArray[i, j] + " " + "\t");
        }
        System.Console.WriteLine();
    }
    return inArray;
}

Console.Clear();
System.Console.WriteLine("введите количество строк: ");
int row = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("введите количество столбцов: ");
int col = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(row, col);
PrintArray(array);

// Задача 48: Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aₙₙ = m+n. 
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5


int[,] GetArray(int m, int n)
{
    int[,] numbers = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            numbers[i, j] = i+j;
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
            System.Console.Write(inArray[i, j] + "\t");
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

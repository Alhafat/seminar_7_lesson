// Задача 51: Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.)
// Например, задан массив:                         
// 1 4 7 2                                     
// 5 9 2 3                                     
// 8 4 2 4                                     

// Сумма элементов главной 
// диагонали: 1+9+2 = 12

int[,] GetArray(int m, int n)
{
    int[,] numbers = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            numbers[i, j] = new Random().Next(1, 10);
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

int SumDiag(int[,] array, int row, int col)
{
    int SumDiag = 0;
    int count = array.GetLength(0) > array.GetLength(1) ? array.GetLength(0) : array.GetLength(1);
    for (int i = 0; i < count; i++)
    {
        SumDiag += array[i, i];
    }
    return SumDiag;
}


Console.Clear();
System.Console.WriteLine("введите количество строк: ");
int row = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("введите количество столбцов: ");
int col = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(row, col);
PrintArray(array);
System.Console.WriteLine();
int result = SumDiag(array, row, col);
System.Console.WriteLine(result);

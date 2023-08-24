// Урок 7. Двумерные массивы
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


PrintMess("Введите количество строк массива: ");
int rows = GetInput();
PrintMess("Введите количество столбцов массива: ");
int columns = GetInput();
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
ArithM(array);

int GetInput()
{
    return int.Parse(Console.ReadLine()!);
}
void PrintMess(string a)
{
    Console.WriteLine(a);
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ArithM(int[,] array)
{
    double result;
    double SumCol;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        SumCol = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            SumCol += array [i, j];
        }
        result = SumCol / array.GetLength(0);
        Console.WriteLine($"Среднее арифметическре {j}-го столбца: {result:f1}");
    }
}


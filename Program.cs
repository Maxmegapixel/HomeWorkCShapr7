// Урок 7. Двумерные массивы
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


PrintInput("Введите количество строк массива: ");
int rows = GetInput();
PrintInput("Введите количество столбцов массива: ");
int columns = GetInput();
PrintArray(GetArray(rows, columns, -10, 10));

int GetInput()
{
    return  int.Parse(Console.ReadLine()!);
}
void PrintInput(string a)
{
    Console.WriteLine(a);
}

double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = rand.NextDouble() * rand.Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(double[,] array)
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
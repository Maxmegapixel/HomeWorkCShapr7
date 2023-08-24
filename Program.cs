// Урок 7. Двумерные массивы
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// позиция i = 4, j = 2 -> такой позиции нет
// позиция i = 1, j = 0 -> 5


PrintMess("Введите количество строк массива: ");
int rows = GetInput();
PrintMess("Введите количество столбцов массива: ");
int columns = GetInput();
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
FindElement(array);

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

void FindElement(int[,] array)
{
    PrintMess("Введите номер строки искомого элемента: ");
    int i = GetInput();
    PrintMess("Введите номер столбца искомого элемента: ");
    int j = GetInput();
    if (i >= array.GetLength(0) || i < 0 || j < 0 || j >= array.GetLength(1)) PrintMess("такого элемента нет!");
    else Console.WriteLine($"Значение элемента: {array[i, j]}");
}


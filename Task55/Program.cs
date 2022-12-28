// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для пользователя.

int[,] Fill(int row, int column, int min, int max)
{
    int[,] arr1 = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr1[i, j] = new Random().Next(min, max);
        }
    }
    return arr1;
}

void Print(int[,] arr2)
{
    for (int i = 0; i < arr2.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            Console.Write($"{arr2[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] Array(int[,] arr3)
{
    int[,] NewArray = new int[arr3.GetLength(0), arr3.GetLength(1)];
    if(arr3.GetLength(0)!=arr3.GetLength(1)) Console.WriteLine($"Поменять местами строки и столбцы невозможно, т.к. матрица не квадратная");
    else
    {
        for (int i = 0; i < arr3.GetLength(0); i++)
        {
            for (int j = 0; j < arr3.GetLength(1); j++)
            {
                NewArray[i,j] = arr3[j,i];
            }
        }
    }
    return NewArray; 
}
int[,] array = Fill(4,4,1,7);
Print(array);
int[,] array1 = Array(array);
Console.WriteLine();
Print(array1);

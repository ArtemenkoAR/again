// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

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

// int[,] Reverce(int[,] arr3)
// {
//     int[,] rev = new int[arr3.GetLength(0), arr3.GetLength(1)];
//     for (int i = 0; i < arr3.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr3.GetLength(1); j++)
//         {
//             rev[i,j] = arr3[arr3.GetLength(0) - 1 - i,j];
//         }
//     }
//     return rev;
// }

void Reverce(int[,] arr3)
{
   int m= arr3.GetLength(0) - 1;
   for (int i = 0,j=0; j < arr3.GetLength(1); j++)
   {
        int x = arr3[i,j];
        arr3[i,j] = arr3[m,j];
        arr3[m,j] = x;  
   }
}

int[,] array = Fill(3, 4, -10, 10);
Print(array);
Console.WriteLine();
// int[,] array1 = Reverce(array);
// Print(array1);
Reverce(array);
Print(array);

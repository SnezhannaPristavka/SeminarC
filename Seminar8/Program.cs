// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// int[,] Change(int[,] matrix)
// {
//     int x;
//     for (int j = 0; j < n; j++)
//     {
//         x = matrix[0, j];
//         matrix[0, j] = matrix[m - 1, j];
//         matrix[m - 1, j] = x;
//     }
// }
// int m = 3;
// int n = 4;
// int[,] matrix = new int[m, n];
// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         matrix[i, j] = new Random().Next(1, 10);
//         Console.Write(matrix[i, j] + " ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();

// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.
// проверка на квадратность массива
void Function(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(matrix[j, i] + " ");
        }
        Console.WriteLine();
    }
}
Console.Write("Введите количество строк в массиве ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве ");
int columns = Convert.ToInt32(Console.ReadLine());
if (row != columns) Console.Write("Невозможно заменить строки на столбцы!");
else Function(row, columns);
//Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
// int [,] Array(int [,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 10);
//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     return matrix;
// }
// void Min(int[,] matrix)
// {
//     int minInd = 0;
//     int minJ = 0;
//     int minValue = matrix[0, 0];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {

//             if(matrix[i, j] < minValue) 
//             {
//                 minValue = matrix[i, j];
//                 minInd = i;
//                 minJ = j;
//             }
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine(minValue);
//     Console.WriteLine(minInd);
//     Console.WriteLine(minJ);
// }

// Console.Write("Введите количество строк в массиве ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов в массиве ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[row, columns];
// Array(matrix);
// Min(matrix);

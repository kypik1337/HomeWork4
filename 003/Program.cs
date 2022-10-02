/*Задача 29: Напишите программу, которая задаёт массив из 8 рандомных элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

void PrintArray (int[] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
            Console.Write($"{matrix[i]} ");
        Console.WriteLine();
    }
}

void FillArray (int[] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
                matrix[i] = new Random().Next(0,10);
        }
    }
int[] matrix = new int[8];
FillArray (matrix);
PrintArray(matrix);
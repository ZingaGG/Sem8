using System.Linq;

int TakeDigit(string a)
{
    System.Console.WriteLine(a);
    int result = Int32.Parse(System.Console.ReadLine());
    return result;
}

int[,] CreateRandomMatrix(int m, int n)
{
    int[,] array = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = Random.Shared.Next(0,10);
        }
    }

    return array;
}

void PrintMatrix(int[,] array)
{
    System.Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           System.Console.Write(array[i,j] + " ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int[,] MatrixSort(int[,] matrix)
{
    for (int k = 0; k < matrix.GetLength(1)-1; k++)
    {
       for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 1; j < matrix.GetLength(1); j++)
            {
                int min = matrix[i,j-1];
                if(matrix[i,j] < min)
                {
                    matrix[i,j-1] = matrix[i,j];
                    matrix[i,j] = min;
                }
            }
        } 
    }
    
    return matrix;
}

int MatrixMinRow(int[,] matrix)
{

    int[] SumsArray = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            SumsArray[i] += matrix[i,j];
        }   
    }

    int Result = Array.IndexOf(SumsArray, SumsArray.Min());
    return Result;
}


// Task 1 Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
/*
int[,] Matrix = CreateRandomMatrix(TakeDigit("Input rows = "), TakeDigit("Input columns = "));

PrintMatrix(Matrix);

Matrix = MatrixSort(Matrix);

PrintMatrix(Matrix);
*/

// Task 2 Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int[,] Matrix = CreateRandomMatrix(TakeDigit("Input rows = "), TakeDigit("Input columns = "));

PrintMatrix(Matrix);

System.Console.WriteLine("Index of Min Row = " + MatrixMinRow(Matrix));
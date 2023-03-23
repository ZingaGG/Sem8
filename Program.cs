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

int[,,] TripleMatrixCreate(int m, int n, int l)
{

    int[,,] Triple = new int[m,n,l];
    int Digit = 10;

    for (int i = 0; i < Triple.GetLength(0); i++)
    {
        for (int j = 0; j < Triple.GetLength(1); j++)
        {
            for (int k = 0; k < Triple.GetLength(2); k++)
            {
                Triple[i,j,k] = Digit;
                Digit++;
            }
        }
    }

    return Triple;
}

void PrintTripleMatrix(int[,,] Triple)
{
    for (int i = 0; i < Triple.GetLength(0); i++)
    {
        for (int j = 0; j < Triple.GetLength(1); j++)
        {
            for (int k = 0; k < Triple.GetLength(2); k++)
            {
                System.Console.WriteLine($"Digit with index{(i,j,k)} = {Triple[i,j,k]}");
            }
        }
    }  
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

int[,]? MatrixMultiply(int[,] a, int[,] b)
{
    if((a.GetLength(0) == b.GetLength(0)) && (a.GetLength(1) == b.GetLength(1)))
    {
        int[,] Result = new int[a.GetLength(0), a.GetLength(1)];
        for (int i = 0; i < Result.GetLength(0); i++)
        {
            for (int j = 0; j < Result.GetLength(1); j++)
            {
                Result[i,j] = a[i,j] * b[i,j];
            }
        }

        return Result;
    }
    else
    {
        System.Console.WriteLine("Matrix's sizes are diffrent!");
        return null;
    }
}




// Task 1 Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
/*
int[,] Matrix = CreateRandomMatrix(TakeDigit("Input rows = "), TakeDigit("Input columns = "));

PrintMatrix(Matrix);

Matrix = MatrixSort(Matrix);

PrintMatrix(Matrix);
*/

// Task 2 Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int[,] Matrix = CreateRandomMatrix(TakeDigit("Input rows = "), TakeDigit("Input columns = "));

PrintMatrix(Matrix);

System.Console.WriteLine("Index of Min Row = " + MatrixMinRow(Matrix));
*/

// Task 3 Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int[,] Matrix = CreateRandomMatrix(TakeDigit("Input rows = "), TakeDigit("Input columns = "));

PrintMatrix(Matrix);

int[,] Matrix2 = CreateRandomMatrix(TakeDigit("Input rows = "), TakeDigit("Input columns = "));

PrintMatrix(Matrix2);

int[,]? Result = MatrixMultiply(Matrix,Matrix2);

System.Console.WriteLine("Result Matrix = ");

PrintMatrix(Result);
*/

// Task 4  Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] Triple = TripleMatrixCreate(2,2,2);

PrintTripleMatrix(Triple);
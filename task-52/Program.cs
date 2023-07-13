/*
Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] FillArrayRandom(int rows, int columns, int min, int max)
{
    int[,] result = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j =0; j < columns; j++)
        {
            result[i, j] = rnd.Next(min, max);
        }
    }
    return result;
}

void PrintArrayDouble(double[,] tmpArray)
{
    
    for (int i = 0; i< tmpArray.GetLength(0); i++)
    {
        for (int j = 0; j < tmpArray.GetLength(1); j++)
        {
            Console.Write($"{tmpArray[i, j]} ");
        }
        Console.WriteLine();
    }  
}

void PrintArray(int[,] tmpArray)
{
    
    for (int i = 0; i< tmpArray.GetLength(0); i++)
    {
        for (int j = 0; j < tmpArray.GetLength(1); j++)
        {
            Console.Write($"{tmpArray[i, j]} ");
        }
        Console.WriteLine();
    }  
}

double[] AvgOfColumns(int[,] tmpArray)
{
    double[] result = new double[tmpArray.GetLength(1)];
    int tmpSum = 0;
    for (int i = 0; i < tmpArray.GetLength(1); i++)
    {
        for(int j = 0; j < tmpArray.GetLength(0); j++)
        {
            tmpSum += tmpArray[j, i];
        }
        result[i] = tmpSum/tmpArray.GetLength(0);
    }
    return result;
}

void Main()
{
    int[,] myArray = FillArrayRandom(3, 4, -10, 10);
    PrintArray(myArray);
    double[] = AvgOfColumns(myArray);
}

Main();
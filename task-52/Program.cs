/*
Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

void PrintArrayDouble(double[] tmpArray)
{
    
    for (int i = 0; i< tmpArray.GetLength(0); i++)
    {
        Console.Write($"{tmpArray[i]} ");
    }  
}

void PrintArrayDouble2(double[,] tmpArray)
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

double[,] FillDoubleRandom(int rows, int columns, int min, int max)
{
    double[,] result = new double[rows, columns];
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

double[] AvgOfColumns(double[,] tmpArray)
{
    double[] result = new double[tmpArray.GetLength(1)];
    double tmpSum = 0;
    for (int i = 0; i < tmpArray.GetLength(1); i++)
    {
       tmpSum = 0;
       for(int j = 0; j < tmpArray.GetLength(0); j++)
        {
            tmpSum += tmpArray[j, i];
        }
        result[i] = Math.Round(tmpSum/tmpArray.GetLength(0), 1);
    }
    return result;
}

void Main()
{
    double[,] myArray = FillDoubleRandom(4, 5, 0, 10);
    PrintArrayDouble2(myArray);
    double[] avgs = AvgOfColumns(myArray);
    System.Console.WriteLine();
    PrintArrayDouble(avgs);
}

Main();
/*
Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9

*/ 


int ReadInt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int InputNaturalInt(string tmpText)
{
    int tmpNumber = ReadInt(tmpText);
    while (tmpNumber <1)
    {
        Console.WriteLine("Это слишком мало! Нужно положительное число.");
        tmpNumber = ReadInt(tmpText);
    }
    return tmpNumber;
}

double[,] FillDoubleRandom(int rows, int columns, int min, int max)
{
    double[,] result = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j =0; j < columns; j++)
        {
            result[i, j] = Math.Round((rnd.Next(min, max)+rnd.NextDouble()), 2);
        }
    }
    return result;
}

void PrintArray(double[,] tmpArray)
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

void Main()
{
    int m = InputNaturalInt("Введите число строк:");
    int n = InputNaturalInt("Введите число столбцов:");
    System.Console.WriteLine($"{m}x{n}");
    int min = ReadInt("Минимальное число в массиве:");
    int max = ReadInt("Максимальное число в массиве:");

    double[,] myArray = FillDoubleRandom(m, n, min, max);
    PrintArray(myArray);

}

Main();
/*
Задача 50. Напишите программу, которая на вход принимает позиции 
элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, 
что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/



int ReadInt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

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

int FindElement(int[,] tmpArray, int index)
{
    int result = 0;
    if (index > 0 && index < tmpArray.GetLength(0)*tmpArray.GetLength(1))
    {
        result = tmpArray[index/tmpArray.GetLength(0), index%tmpArray.GetLength(0)];
    }
    else result = -1;
    return result;
}

void Main()
{
    int[,] myArray = FillArrayRandom(4, 3, -10, 10);
    PrintArray(myArray);
    int N = ReadInt("Введите номер элемента, который будем искать:");
    int A = FindElement(myArray, N);
    if (A == -1) {System.Console.WriteLine("такого элемента нет");}
    else System.Console.WriteLine(A);
}

Main();
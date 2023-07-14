/*
Задача 50. Напишите программу, которая на вход принимает 
позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, 
что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
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

/*тут я неправильно поняла задачу и предлагала ввести одно число (17), 
элементы считала по порядку (с левого верзхнего по строкам)

int FindElementInOrder(int[,] tmpArray, int tmpIndex)
{
    int result = 0;
    if (tmpIndex > 0 && tmpIndex < tmpArray.GetLength(0)*tmpArray.GetLength(1))
    {
        result = tmpArray[tmpIndex/tmpArray.GetLength(0), tmpIndex%tmpArray.GetLength(0)];
    }
    else result = -1;
    return result;
}

int ReadInt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
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

*/

int[] ReadArray1(string text)
{
    System.Console.WriteLine(text);
    int[] result = Array.ConvertAll(Console.ReadLine()!.Split(" "), int.Parse);
    return result;
}

int FindElement(int[,] tmpArray, int[] tmpIndex)
{
    int result = tmpArray[tmpIndex[0]-1, tmpIndex[1]-1];
    return result;
}

bool CheckIndex(int[,] tmpArray, int[] tmpIndex)
{
    if (tmpIndex[0]-1 < tmpArray.GetLength(0) && tmpIndex[1]-1 < tmpArray.GetLength(1))
    {
        return true;
    }
    else return false;
}

void Main()
{
    int[,] myArray = FillArrayRandom(3, 5, -10, 10);
    PrintArray(myArray);
    int [] indexes = ReadArray1("Введите номер строки и столбца, где расположен элемент, через пробел (например, 2, 5):");
    if (CheckIndex(myArray, indexes)) System.Console.WriteLine(FindElement(myArray, indexes));
    else System.Console.WriteLine("такого элемента нет");
}

Main();
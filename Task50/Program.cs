// Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же указание,
//  что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет



Console.WriteLine("введите номер строки");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int m = Convert.ToInt32(Console.ReadLine());


int[,] matrica = new int [4, 4];
Generate2DArray(matrica);
Print2DArray(matrica);
if(IsContain(matrica, m, n))
{
    System.Console.WriteLine($"Число = {matrica[m, n]}");
}

bool IsContain(int[,] matrix, int m, int n)
{
    return ((m < matrix.GetLength(0) && m >= 0) && (n < matrix.GetLength(1) && n >= 0));
}

void Generate2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i, j] = new Random().Next(1, 30);
            }   
        }
        return;
}

void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");
        }   
        Console.WriteLine(); 
    }
}
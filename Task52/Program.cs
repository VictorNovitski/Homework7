// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее
// арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.WriteLine("введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());

int[,] matrica = new int[n, m];
Generate2DArray(matrica);
Print2DArray(matrica);
var arr = Avarage(matrica); 
Console.WriteLine();
PrintArray(arr);

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + "  " );
    }
} 

void Generate2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return;
}

void Print2DArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Console.WriteLine("Среднее арифметическое каждого столбца: ");
double[] Avarage(int[,] matrica)
{
    double[] result = new double[matrica.GetLength(1)];

for (int j = 0; j < matrica.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < matrica.GetLength(0); i++)
    {
        avarage = (avarage + matrica[i, j]);
    }
    avarage = avarage / n;
    result[j] = avarage;
}
return result; 
}
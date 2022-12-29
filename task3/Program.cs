/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/


// задать матрицу и заполнить ее числами
void FillArray(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        matrix[i, j ] = new Random().Next(1,10);
        }
    }
}

// печать массива
void PrintArray (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}


//нахождение среднеарифмитеческого значения 
void Average(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j ++)
    {
       double summ = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        summ  += matrix [i, j];
    }
    Console.WriteLine($"Среднее арифметическое: {summ/matrix.GetLength(0)}");
    }
}



int[,] matrix = new int[3,4];
FillArray(matrix);
PrintArray(matrix);

Average(matrix);




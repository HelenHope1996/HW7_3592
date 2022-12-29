/*Задача 50. Напишите программу, которая на вход принимает позиции элемента
 в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

//получить числа с консоли
int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }

    return result;
}

//задать матрицу и заполнить ее числами
int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        matrix[i, j ] = rnd.Next(1, 99);
        }
    }

    return matrix;
}

//распечатать матрицу
void PrintMatrix(int[,] matrix)
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


int m = GetNumber("Введите количество строк:");
int n = GetNumber("Введите количество столбцов");
int[,] matrix = GetMatrix(m,n);
PrintMatrix(matrix);


Console.WriteLine("Введите строчку: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите столбик: ");
int colums = Convert.ToInt32(Console.ReadLine());


 if (rows < 0 && rows > matrix.GetLength(0) - 1 && colums < 0 && colums > matrix.GetLength(1) - 1)
 {
    Console.WriteLine($"{matrix[rows, colums]} - такого числа нет");
 }
 else
 {
    Console.WriteLine($"Значение элемента массива = {matrix[rows, colums]}");
 }



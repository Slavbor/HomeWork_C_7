// Задача 47. Напишите программу реализующую метод,
//  который возвращает массив размером m×n,
//   заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9



using static System.Console;

Clear();
WriteLine();
WriteLine("    # Matrix generation #");
WriteLine();

Write("Enter numbers of matrix rows: ");
int arrayRows = int.Parse(ReadLine()!);
Write("Enter numbers of matrix columns: ");
int arrayColumns = int.Parse(ReadLine()!);
WriteLine();

double[,] array = GetMatrixArray(arrayRows, arrayColumns);

PrintMatrixArray(array);
WriteLine();

double[,] GetMatrixArray(int rows, int columns)
{
    Random rand = new Random();
    double[,] resultArray = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i, j] = rand.NextDouble() * (-10 + 100) - 10;
        }
    }
    return resultArray;
}

void PrintMatrixArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{Math.Round(inArray[i, j], 1), 5} "); // вывод в 3 символа
        }
        WriteLine();
    }
}

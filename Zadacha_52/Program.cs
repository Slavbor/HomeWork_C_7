// Задача 52. Напишите программу реализующую методы, 
// формирования двумерного массива и массива средних 
// арифметических значений каждого столбца.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using static System.Console;

Clear();
WriteLine();
WriteLine("    # MaTrix GeNeRaTiNg & Column average calculation #");
WriteLine();

Write("Enter numbers of matrix rows: ");
int RowsMain = int.Parse(ReadLine()!);
Write("Enter numbers of matrix columns: ");
int ColumnsMain = int.Parse(ReadLine()!);
Write("Enter Min value of matrix element: ");
int minValueArray = int.Parse(ReadLine()!);
Write("Enter Max value of matrix element: ");
int maxValueArray = int.Parse(ReadLine()!);
WriteLine();
int[,] array = GetMatrixArray(RowsMain, ColumnsMain, minValueArray, maxValueArray);
PrintMatrixArray(array);
WriteLine();
WriteLine("-=Average of each column=-");

  double summ = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {

            summ += array[j, i];
            

        }
        Write($"  {Math.Round(summ / array.GetLength(0), 1)}");       
        summ = 0;
    }
WriteLine();
WriteLine();

int[,] GetMatrixArray(int arrayRows, int arrayColumns, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[,] resultArray = new int[arrayRows, arrayColumns];
    for (int i = 0; i < arrayRows; i++)
    {
        for (int j = 0; j < arrayColumns; j++)
        {
            resultArray[i, j] = rnd.Next(minValue, maxValue);
        }
    }
    return resultArray;
}

void PrintMatrixArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j], 4} "); // вывод в 3 символа
        }
        WriteLine();
    }
}

// int[,] ColumnAverageCalc(int[,] AveregeArray)
// {   



// }
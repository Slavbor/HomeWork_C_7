// Задача 50. Напишите программу реализующую метод,
// принимающий позиции элемента в двумерном массиве,
//  и возвращающий значение этого элемента или же указание,
//   что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1;7 -> такого элемента в массиве нет
// 1;1 -> 9

using static System.Console;

Clear();
WriteLine();
WriteLine("    # MaTrix GeNeRaTiNg & element found #");
WriteLine();

Write("Enter numbers of matrix rows: ");
int RowsMain = int.Parse(ReadLine()!);
Write("Enter numbers of matrix columns: ");
int ColumnsMain = int.Parse(ReadLine()!);
Write("Enter Min value of matrix element: ");
int minValueArray = int.Parse(ReadLine()!);
Write("Enter Max value of matrix element: ");
int maxValueArray = int.Parse(ReadLine()!);
Write("Enter the row number for element search: ");
int elementRows = int.Parse(ReadLine()!);
Write("Enter the column number for element search: ");
int elementColumn = int.Parse(ReadLine()!);
WriteLine();

int[,] array = GetMatrixArray(RowsMain, ColumnsMain, minValueArray, maxValueArray);
PrintMatrixArray(array);
WriteLine();

if (elementRows >= RowsMain || elementColumn >= ColumnsMain)
{
    WriteLine($"  Position wrong! Not exist.");
    WriteLine();
    return;
}

foreach (int element in array)
{
    if (element == array[elementRows, elementColumn])
    {
        WriteLine($"Your matrix element: {element}");
        WriteLine();
        return;
    }
}

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
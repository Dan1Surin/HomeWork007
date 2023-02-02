// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// 11-14
// 14-44
// 44-41
// 41-21
// 21-23
// 23-33
// 33-32

int[,] getRandomMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];


int number = 1;
int i = 0;
int j = 0;
int n =4;
while (number <= 16)
{
    matrix[i, j] = number;
    if (i <= j + 1 && i + j < n - 1)
        ++j;
    else if (i < j && i + j >= n - 1)
        ++i;
    else if (i >= j && i + j > n - 1)
        --j;
    else
        --i;
    ++number;
}
        Console.WriteLine();

    return matrix;
}

int ROWS = 4;
int COLUMNS = 4;

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j]<10)
            {
                Console.Write("0"+matr[i, j] + " ");
            }
            else {Console.Write(matr[i, j] + " ");}
        }
        Console.WriteLine();
    }
}

int[,] Matrix = getRandomMatrix(ROWS, COLUMNS);
PrintMatrix(Matrix);

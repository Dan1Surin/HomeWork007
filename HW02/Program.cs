// Задача 56: Задайте двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер
// строки с наименьшей суммой элементов: 1 строка
int[,] getRandomMatrix(int rows, int columns, int lRange, int rRange)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(lRange, rRange + 1);
        }
    }
    return matrix;
}

int ROWS = 3;
int COLUMNS = 4;
const int LR = 0;
const int RR = 9;

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] Matrix = getRandomMatrix(ROWS, COLUMNS, LR, RR);
PrintMatrix(Matrix);

void SumRows(int[,] matr)
{
    int sum = 0;
    int arg=0;
    int[] array = new int[matr.GetLength(0)];

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                sum = sum + matr[i, j];
            }
            array[i] = sum;
            sum=0;
        }
    }
    int min = array[0];
   
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        
        if (array[i]<min)
        {
            arg=i;
        }

    }
    //Console.WriteLine(string.Join(",", array));
    Console.WriteLine(arg+1 + " строка");
}

SumRows(Matrix);

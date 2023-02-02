// Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// (допустимый вариант)
// 6 16
// // 9 6
// C = A · B =  
// 1	3
// 3	3
//   ·  
// 2	3
// 2	0
//   =  
// 8	3
// 12	9
 
// Компоненты матрицы С вычисляются следующим образом:

// c11 = a11 · b11 + a12 · b21 = 1 · 2 + 3 · 2 = 2 + 6 = 8

// c12 = a11 · b12 + a12 · b22 = 1 · 3 + 3 · 0 = 3 + 0 = 3

// c21 = a21 · b11 + a22 · b21 = 3 · 2 + 3 · 2 = 6 + 6 = 12

// c22 = a21 · b12 + a22 · b22 = 3 · 3 + 3 · 0 = 9 + 0 = 9p

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

int ROWS = 2;
int COLUMNS = 2;
const int LR = 0;
const int RR = 3;


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
Console.WriteLine();
int[,] Matrix2 = getRandomMatrix(ROWS, COLUMNS, LR, RR);
PrintMatrix(Matrix2);
Console.WriteLine();
int[,] Matrix3 = getRandomMatrix(ROWS, COLUMNS, LR, RR);
PrintMatrix(Matrix3);
Console.WriteLine();

void MatrixMultiplication(int[,] matr,int[,] matr2,int[,] matr3)
{
    for (int i = 0; i < matr.GetLength(0)-1; i++)
    {
        for (int j = 0; j < matr.GetLength(1)-1; j++)
        { 
           matr3[i,j]=matr[i,j]*matr2[i,j]+matr[i+1,j]*matr2[i,j+1];
        }
    }
    Console.WriteLine();
    PrintMatrix(matr2);
}

MatrixMultiplication(Matrix,Matrix2,Matrix3);
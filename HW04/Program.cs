// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//  Напишите программу, которая будет построчно выводить массив, добавляя индексы
//  каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int[,,] getRandomMatrix(int X, int Y, int Z)
{
    int[,,] matrix = new int[X,Y,Z];
    int number = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++) 
            { 
                matrix[i,j,k]= number;
                number=number+5;
            }
        }
    }
    return matrix;
}

int X = 2;
int Y = 2;
int Z = 2;

void PrintMatrix(int[,,] matr)
{
     for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++) 
            { 
                Console.Write($" {matr[i,j,k]} ({i},{j},{k})");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,,] Matrix = getRandomMatrix(X,Y,Z);
PrintMatrix(Matrix);
Console.WriteLine();

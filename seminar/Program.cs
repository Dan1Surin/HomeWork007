// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.

// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. Транспанирование матрицы

// Задача 57: Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается
//  элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6

// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза
// В нашей исходной матрице встречаются элементы от 0 до 9

// Домашняя работа

// Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

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
int COLUMNS = 3;
const int LR = 0;
const int RR = 10;

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

void ChangeSymbole(int[,] matr)
{
    int temp = 0;

    for (int j = 0; j < matr.GetLength(1); j++)
    {
        temp = matr[0, j];
        matr[0, j] = matr[2, j];
        matr[2, j] = temp;
    }
    Console.WriteLine();
    PrintMatrix(matr);
}

void TransponirMatrix(int[,] matr)
{
    int[,] trans = new int[matr.GetLength(1), matr.GetLength(0)];

    for (int i = 0; i < trans.GetLength(0); i++)
    {
        for (int j = 0; j < trans.GetLength(1); j++)
        {
            trans[i, j] = matr[j, i];
        }
    }
    Console.WriteLine();
    PrintMatrix(trans);
}

void ElementFrequency(int[,] matr)//не закончен
{
    int a = 0;
    int count = 0;

    for (a = 0; a < 12; a++)
    {
        AA:
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                if (matr[i, j] == a)
                {
                    count++;
                    a++;
                    goto AA;
                }
            }
           
        }
    }

    Console.WriteLine(count + "количетво уникальных элементов");
    int[,] matr1 = new int[count, 1];
  
}

ElementFrequency(Matrix);

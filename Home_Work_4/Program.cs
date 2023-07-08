// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    { 
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} "); 
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ArrayRandom(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1, 10);
        }
    }
}

void Summa(double[,] array , double[,] array2, double[,] result)
{
    double tmp = 0;
    double tmp2 = 10000;
    double resul = 0;

    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                resul = array[i,j] * array2[j,k];

                if(tmp < resul)
                {
                    tmp = resul;
                }

                if(tmp2 > resul)
                {
                    tmp2 = resul;
                } 

            }


            result[i,k] = tmp + tmp2;

            tmp = 0;
            tmp2 = 10000;

        }
    }

}


double[,] array = new double[2,2];
double[,] array2 = new double[2,2];

double[,] result = new double[2,2];

ArrayRandom(array);
ArrayRandom(array2);

PrintArray(array);
PrintArray(array2);

Summa(array , array2, result);

PrintArray(result);
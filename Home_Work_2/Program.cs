// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
            array[i,j] = new Random().Next(1, 100);
        }
    }
}

void Summa(double[,] array)
{
    double tpm = 100000;
    double count = 0;
    double count2 = 1;
    double numbers = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    { 
        numbers = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            numbers = numbers + array[i,j];
        }

        Console.WriteLine($"Сумма элементов {numbers} в строке {count2++}");

        if(numbers < tpm)
        {
            tpm = numbers;
            count = i+1;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Самая наименшая сумма элементов {tpm} в строке {count}");
    Console.WriteLine();
}

double[,] array = new double[4,4];

PrintArray(array);
ArrayRandom(array);
PrintArray(array);
Summa(array);

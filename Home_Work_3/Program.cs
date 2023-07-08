// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    { 
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i,j,k]} ({i},{j},{k}) "); 
                
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

bool comparisons(int numbers, int[,,] array)
{
    bool comparisons1 = true;

    for (int i = 0; i < array.GetLength(0); i++)
    { 
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if(numbers == array[i,j,k])
                {
                    comparisons1 = false;
                }
                
            }
        }
    }

    return comparisons1;

}

void fillArray(int[,,] array)
{
    int tmp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    { 
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                for (int t = 0; t < array.GetLength(2); t++)
                {
                    tmp = new Random().Next(10,100);
                    if(comparisons(tmp, array))
                    {
                        array[i,j,k] = tmp;
                    }
                    
                }
                
            }
            
        }
        
    }

}

int[,,] array3D = new int[2,2,2];

Console.Clear();

PrintArray(array3D);
fillArray(array3D);
PrintArray(array3D);
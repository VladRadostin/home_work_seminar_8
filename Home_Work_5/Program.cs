// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void PrintArray(int[,] array)
{
    int len = array.GetLength(0) / 2;
    for (int i = 0; i < array.GetLength(0); i++)
    { 
        for (int j = 0; j < array.GetLength(1); j++)
        {
            string str = Convert.ToString(array[i,j]);
            str = str.PadLeft(len, ' ');
            Console.Write($"{str} "); 
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] array = new int[4,4];

void fillArray(int x, int y, int count, int d_row, int d_colim)
{
    int len = array.GetLength(0);
    if(0 <= x+d_row & x+d_row < len & 0 <= y+d_colim & y+d_colim < len  && array[x+d_row,y+d_colim] == 0)
    {
        x = x + d_row;
        y = y + d_colim;
        array[x,y] = count;
        count = count + 1;
        // PrintArray(array);

        if(d_colim == -1 & 0 <= x+d_row & x+d_row < 4 & 0 <= y+d_colim & y+d_colim < 4  && array[x+d_row,y+d_colim] == 0)
        {
            fillArray(x, y, count, d_row = 0, d_colim = -1);
        }

        if(d_row == -1 & 0 <= x+d_row & x+d_row < 4 & 0 <= y+d_colim & y+d_colim < 4  && array[x+d_row,y+d_colim] == 0)
        {
            fillArray(x, y, count, d_row = -1, d_colim = 0);
        }

        fillArray(x, y, count, d_row = 0, d_colim = 1);
        fillArray(x, y, count, d_row = 1, d_colim = 0);
        fillArray(x, y, count, d_row = 0, d_colim = -1);
        fillArray(x, y, count, d_row = -1, d_colim = 0);

    }

}

PrintArray(array);
fillArray(0, -1, 1, 0, 1);
PrintArray(array);


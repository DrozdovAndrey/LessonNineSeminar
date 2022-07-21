// Задача 2. Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты
// Например, изначально массив выглядел вот так:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// Новый массив будет выглядеть вот так:

// 1 4 7 2

// 5 81 2 9

// 8 4 2 4




namespace Seminar9
{
    class Task2
    {
        static void Main(string[] args)
        {
            int n = new Random().Next(3, 7);
            int m = new Random().Next(3, 7);
            int[,] array = new int[m, n];
            FillArray(array);
            Console.WriteLine($"Начальный массив:  ");
            PrintArray(array);
            // Console.WriteLine();
            Console.WriteLine($"Индексы минимальногшо числа в массиве: {GetMinIndex(array)[0]} {GetMinIndex(array)[1]}");
            Console.WriteLine();
            Console.WriteLine($"Массив без строки и столбца: {GetMinIndex(array)[0] +1} {GetMinIndex(array)[1] +1}");
            PrintArray(DeleteColStr(array, GetMinIndex(array)));
        }
        static void FillArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(0, 10);
                }
            }
        }
        public static int[] GetMinIndex(int[,] array)
        {
            int[] minIndex = new int[2];
            int minI = 0;
            int minJ = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if(array[i,j] < array[minI,minJ]) 
                    {
                        minI = i;
                        minJ = j;
                        minIndex[0] = i;
                        minIndex[1] = j;
                    }
                }
            }
            return minIndex;
        }
        static int[,] DeleteColStr(int[,] array, int[] minIndex)
        {
            int[,] number = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
            for (int i = 0, m = 0; i < array.GetLength(0) && m < number.GetLength(0); i++, m++)
            {
                if(i == minIndex[0] ) i++;
                for (int j = 0, n = 0; j < array.GetLength(1) && n < number.GetLength(1); j++, n++)
                {
                    if(j == minIndex[1]) j++;
                    number[m,n] = array[i,j];
                }
            }
            return number;
        }
        static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
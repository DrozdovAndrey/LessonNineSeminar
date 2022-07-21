



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
            Console.WriteLine("Перевернутый массив: ");
            ReplacLine(array);
            PrintArray(array);
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
        static void ReplacLine(int[,] array)
        {
            int lineEnd = array.GetLength(0) - 1;
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    int number = array[i, j];
                    array[i, j] = array[lineEnd, j];
                    array[lineEnd, j] = number;
                }

            }

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
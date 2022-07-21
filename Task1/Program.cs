// Задача 1. Из двумерного массива целых чисел удалить строку и столбец,
//  на пересечении которых расположен наименьший элемент.



namespace Seminar9
{
    class Task2
    {
        static void Main(string[] args)
        {
            int n = new Random().Next(3, 7);
            int m = new Random().Next(3, 7);
            int[,] array = new int[n, m];
            FillArray(array);
            Console.WriteLine("Начальный Массив");
            PrintArray(array);
            SquareEvenIndex(array);
             Console.WriteLine("Массив после выполнения программы");
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
        static void SquareEvenIndex(int[,] array)
        {

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i % 2 == 0 && j % 2 == 0) array[i, j] = array[i, j] * array[i, j];
                }
            }
        }
    }
}
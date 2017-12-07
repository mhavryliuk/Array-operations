using System;

namespace ArrayOperations
{
    static class ArrayOperations
    {
        // Создание массива
        internal static void CreatingАrray(out int arraySize, out int[] array)
        {
            Console.Write("Укажите количество элементов массива: ");
            arraySize = Convert.ToInt32(Console.ReadLine());
            array = new int[arraySize];

            // Наполнение массива
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nВведите элементы массива...");
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write("Элемент [{0}]: ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.ResetColor();
        }

        // Вывод массива
        internal static void ArrayOutput(int[] array)
        {
            Console.Write("\nСоздан массив: ");
            foreach (int item in array)
                Console.Write("{0} ", item);
        }

        // Поиск наибольшего элемента массива
        internal static void SearchLargestElement(int[] array)
        {
            int max = array[0];
            foreach (int item in array)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            Console.WriteLine($"\nНаибольший элемент массива: {max}");
        }

        // Поиск наименьшего элемента массива
        internal static void SearchSmallestElement(int[] array)
        {
            int min = array[0];
            foreach (int item in array)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            Console.WriteLine($"Наименьший элемент массива: {min}");
        }

        // Вычисление общей суммы всех элементов массива
        internal static int CalculationTotalAmount(int[] array)
        {
            int sum = 0;
            foreach (int item in array)
            {
                sum += item;
            }
            Console.WriteLine($"Суммы всех элементов массива: {sum}");
            return sum;
        }

        // Вычисление среднего арифметического всех элементов массива
        internal static void CalculationArithmeticMean(int arraySize, int sum)
        {
            int average = sum / arraySize;
            Console.WriteLine($"Среднее арифметическое всех элементов массива: {average}");
        }

        // Вывод всех нечетных элементов массива
        internal static void OutputOddElements(int[] array)
        {
            Console.Write("Нечетные элементы массива: ");
            foreach (int item in array)
            {
                if (item % 2 != 0)
                {
                    Console.Write("{0} ", item);
                }
            }
        }
    }
}

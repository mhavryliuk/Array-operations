using System;

/*
Требуется: 
Создать массив размером N элементов, заполнив его произвольными целыми значениями (размер массива задает пользователь).
Вывести на экран: 
- наибольшее значение массива, 
- наименьшее значение массива, 
- общую сумму всех элементов, 
- среднее арифметическое всех элементов, 
- вывести все нечетные значения.
*/

namespace ArrayOperations
{
    class Program
    {
        static void Main()
        {
            ArrayOperations.CreatingАrray(out int arraySize, out int[] array);         // Создание массива
            ArrayOperations.ArrayOutput(array);                                        // Вывод массива
            ArrayOperations.SearchLargestElement(array);                               // Поиск наибольшего элемента массива
            ArrayOperations.SearchSmallestElement(array);                              // Поиск наименьшего элемента массива
            int sum = ArrayOperations.CalculationTotalAmount(array);                   // Вычисление общей суммы всех элементов массива
            ArrayOperations.CalculationArithmeticMean(arraySize, sum);                 // Вычисление среднего арифметического всех элементов массива
            ArrayOperations.OutputOddElements(array);                                  // Вывод всех нечетных элементов массива

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul_3
{
    internal class Задание_3
    {
        /*Задание 3
        Напишите метод, фильтрующий массив на основании переданных параметров.
        Метод принимает параметры: оригинальный_массив, массив_с_данными_для_фильтрации.
        Метод возвращает оригинальный массив без элементов, которые есть в массиве для фильтрации.
        Например:
        1 2 6 -1 88 7 6 — оригинальный массив;
        6 88 7 — массив для фильтрации;
        1 2 -1 — результат работы метода.*/
        public static int[] FilterArray(int[] originalArray, int[] filterArray)
        {
            // создаем массив для результата, с таким же размером как и оригинальный массив
            int[] resultArray = new int[originalArray.Length]; 
            int index = 0; // индекс для записи элементов в результирующий массив

            for (int i = 0; i < originalArray.Length; i++) // проход по оригинальному массиву
            {
                bool found = false;
                for (int j = 0; j < filterArray.Length; j++) // проход по массиву для фильтрации
                {
                    if (originalArray[i] == filterArray[j]) // если элемент из оригинального массива найден в массиве для фильтрации
                    {
                        found = true;
                        break; // прерываем поиск, так как элемент уже найден
                    }
                }
                if (!found) // если элемент не был найден в массиве для фильтрации
                {
                    resultArray[index] = originalArray[i]; // записываем его в результирующий массив
                    index++; // увеличиваем индекс на единицу
                }
            }

            int[] finalArray = new int[index]; // создаем массив для финального результата
            // копируем найденные элементы из результирующего массива в финальный массив
            for (int i = 0; i < index; i++)
                finalArray[i] = resultArray[i];
            return finalArray;
        }

        static void Main(string[] args)
        {
            int[] originalArray = new int[] { 1, 2, 6, -1, 88, 7, 6 };
            Console.WriteLine("Оригинальный массив:\n" + string.Join(" ", originalArray));
            int[] filterArray = new int[] { 6, 88, 7 };
            Console.WriteLine("Массив для фильтрации:\n" + string.Join(" ", filterArray));
            int[] filteredArray = FilterArray(originalArray, filterArray);
            Console.WriteLine("Результат работы метода:\n" + string.Join(" ", filteredArray)); // выводит 1 2 -1
        }
    }
}

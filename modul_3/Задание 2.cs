using System;

namespace modul_3
{
    /*Задание 2
    Напишите метод, который проверяет является ли переданное число «палиндромом».
    Число передаётся в качестве параметра. 
    Если число палиндром нужно вернуть из метода true, иначе false.
    Палиндром — число, которое читается одинаково как справа налево, так и слева направо. 
    Например:
    1221 — палиндром;
    3443 — палиндром;
    7854 — не палиндром.*/
    internal class Задание_2
    {
        public static bool IsPalindrome(int number)
        {
            // конвертируем число в строку
            string numberString = number.ToString();
            int length = numberString.Length;
            // проверяем символы с начала и конца строки
            for (int i = 0; i < length / 2; i++) 
            {
                // если символы не совпадают, возвращаем false
                if (numberString[i] != numberString[length - i - 1])
                    return false;
            } // если прошли все итерации и символы совпадают, значит это палиндром
            return true; 
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");
            int number = int.Parse(Console.ReadLine());

            if (IsPalindrome(number)) Console.WriteLine($"{number} - палиндром");
            else Console.WriteLine($"{number} - не палиндром");
        }
    }
}

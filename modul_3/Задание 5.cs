using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul_3
{
    internal class Задание_5
    {
        /*Задание 5
        Создайте класс «Журнал». 
        Необходимо хранить в полях класса: 
        название журнала, год основания, описание журнала, контактный телефон, контактный e-mail.
        Реализуйте методы класса для ввода данных, вывода данных, реализуйте доступ к отдельным полям через методы класса. */

        class Journal
        {
            string name;
            int year;
            string description;
            string phone;
            string email;
            public string GetName() => name;                      // тоже самое  { return name; }
            public void SetName(string name) => this.name = name; // тоже самое  { this.name = name }
            public int GetYear() => year;
            public void SetYear(int year) => this.year = year;
            public string GetDescription() => description;
            public void SetDescription(string description) => this.description = description;
            public string GetPhone() => phone;
            public void SetPhone(string phone) => this.phone = phone;
            public string GetEmail() => email;
            public void SetEmail(string email) => this.email = email;
            public void PrintJournal()
            {
                Console.WriteLine("Журнал:        {0}", GetName());
                Console.WriteLine("Год основания: {0}", GetYear());
                Console.WriteLine("Описание:      {0}", GetDescription());
                Console.WriteLine("Телефон:       {0}", GetPhone());
                Console.WriteLine("Email:         {0}", GetEmail());
            }
            public void InputJournal()
            {
                Console.Write("Введите название журнала: ");
                SetName(Console.ReadLine());

                Console.Write("Введите год основания: ");
                SetYear(int.Parse(Console.ReadLine()));

                Console.Write("Введите описание журнала: ");
                SetDescription(Console.ReadLine());

                Console.Write("Введите контактный телефон: ");
                SetPhone(Console.ReadLine());

                Console.Write("Введите контактный email: ");
                SetEmail(Console.ReadLine());
            }
        }
        static void Main(string[] args)
        {
            int count = 2;
            Journal[] journal = new Journal[count];

            for (int i = 0; i < count; i++)
            {
                journal[i] = new Journal();
                journal[i].InputJournal();
                Console.WriteLine();
            }
            for (int i = 0; i < count; i++)
            {
                journal[i].PrintJournal();
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

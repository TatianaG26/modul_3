using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul_3
{
    internal class Задание_6
    {
        /*Задание 6
        Создайте класс «Магазин». 
        Необходимо хранить в полях класса: 
        название магазина, адрес, описание профиля магазина, контактный телефон, контактный e-mail.
        Реализуйте методы класса для ввода данных, вывода данных, реализуйте доступ к отдельным полям через методы класса. */
        static void Main(string[] args)
        {
            Shop[] shops = new Shop[2]; // создание массива объектов класса магазин
            for (int i = 0; i < shops.Length; i++)
            {
                Console.WriteLine("\nВведите данные для магазина № {0}", i + 1);
                shops[i] = new Shop("", "", "", "", ""); // создание нового объекта класса магазин
                shops[i].Input(); // ввод данных для текущего магазина
            }

            Console.WriteLine("\nДанные всех магазинов:\n");

            foreach (Shop shop in shops)
                shop.Output(); // вывод данных для текущего магазина
        }
        class Shop
        {
            string name;
            public string Name { get => name; set => this.name = value; } // вместо методов Set/Get использую автоматические свойства
            string address;
            public string Address { get => address; set => this.address = value; }
            string profileDescription;
            public string ProfileDescription { get => profileDescription; set => this.profileDescription = value; }
            string phoneNumber;
            public string PhoneNumber { get => phoneNumber; set => this.phoneNumber = value; }
            string email;
            public string Email { get => email; set => this.email = value; }
            // конструктор класса
            public Shop(string name, string address, string profileDescription, string phoneNumber, string email) // конструктор класса
            {
                this.name = name;
                this.address = address;
                this.profileDescription = profileDescription;
                this.phoneNumber = phoneNumber;
                this.email = email;
            }
            public void Input()
            {
                Console.Write("Введите название магазина: ");
                Name = Console.ReadLine();

                Console.Write("Введите адрес магазина: ");
                Address = Console.ReadLine();

                Console.Write("Введите описание магазина: ");
                ProfileDescription = Console.ReadLine();

                Console.Write("Введите контактный телефон: ");
                PhoneNumber = Console.ReadLine();

                Console.Write("Введите контактный e-mail: ");
                Email = Console.ReadLine();
            }
            public void Output()
            {
                Console.WriteLine("Название магазина:  {0}", Name);
                Console.WriteLine("Адрес магазина:     {0}", Address);
                Console.WriteLine("Описание магазина:  {0}", ProfileDescription);
                Console.WriteLine("Контактный телефон: {0}", PhoneNumber);
                Console.WriteLine("Контактный e-mail:  {0}", Email);
            }
        }
    }
}

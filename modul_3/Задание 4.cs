using System;

namespace modul_3
{
    internal class Задание_4
    {
        /*Задание 4
        Создайте класс «Веб-сайт». 
        Необходимо хранить в полях класса: название сайта, путь к сайту, описание сайта, ip адрес сайта. 
        Реализуйте методы класса для ввода данных, вывода данных, реализуйте доступ к отдельным полям через методы класса.*/
        static void Main(string[] args)
        {
            int websiteCount = 2;
            Website[] websites = new Website[websiteCount];
            for (int i = 0; i < websiteCount; i++)
            {
                websites[i] = new Website();
                websites[i].Input();
                Console.WriteLine();
            }
            for (int i = 0; i < websiteCount; i++)
            {
                websites[i].Output();
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        class Website
        {
            private string siteName;
            private string sitePath;
            private string siteDescription;
            private string siteIp;
            public void SetSiteName(string name) => siteName = name; // тоже самое { siteName = name;}
            public void SetSitePath(string path) => sitePath = path;
            public void SetSiteDescription(string description) => siteDescription = description;
            public void SetSiteIp(string ip) => siteIp = ip;
            public string GetSiteName() => siteName; // тоже самое { return siteName;}
            public string GetSitePath() => sitePath;
            public string GetSiteDescription() => siteDescription;
            public string GetSiteIp() => siteIp;
            public void Input()
            {
                Console.Write("Введите название сайта: ");
                SetSiteName(Console.ReadLine());

                Console.Write("Введите путь к сайту:   ");
                SetSitePath(Console.ReadLine());

                Console.Write("Введите описание сайта: ");
                SetSiteDescription(Console.ReadLine());

                Console.Write("Введите IP-адрес сайта: ");
                SetSiteIp(Console.ReadLine());
            }
            public void Output()
            {
                Console.WriteLine("Название сайта: " + GetSiteName());
                Console.WriteLine("Путь к сайту:   " + GetSitePath());
                Console.WriteLine("Описание сайта: " + GetSiteDescription());
                Console.WriteLine("IP-адрес сайта: " + GetSiteIp());
            }
        }
    }
}

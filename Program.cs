using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        #region Work 1

        List<int> list = new List<int>();
        var rand = new Random();
        for (int i = 0; i < 100; i++)
        {
            list.Add(rand.Next(0, 100));
        }

        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }

        Console.ReadLine();

        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] > 25 & list[i] < 50)
            {
                list.RemoveAt(i);
                i--;
            }
        }

        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }
        #endregion
        Console.Clear();
        #region Work 2
        Console.WriteLine("Задание 2");
        Dictionary<string, string> phone = new Dictionary<string, string>();

        string? fio;
        string? phoneNumber;
        while (true)
        {
            Console.WriteLine("Введите номер Абонента");
            phoneNumber = Console.ReadLine();
            if (string.IsNullOrEmpty(phoneNumber))
            {
                break;
            }
            Console.WriteLine("Введите ФИО абонента");
            fio = Console.ReadLine();
            if (string.IsNullOrEmpty(fio))
            {
                break;
            }
            phone.Add(phoneNumber, fio);
            Console.WriteLine("Абонент успешно записан");
        }

        Console.WriteLine("Введите номер для поиска абонента:");
        string? phonePoisk = Console.ReadLine();

        if(phone.TryGetValue(phonePoisk, out fio))
        {
            Console.WriteLine($"ФИО абонента: {fio}");
        }
        else
        {
            Console.WriteLine("Нет абонента по данному номеру");
        }
        Console.ReadLine();
        #endregion
        Console.Clear();
        #region Work3
        Console.WriteLine("Задание 3");
        HashSet<string> strings = new HashSet<string>();
        while (true)
        {
            Console.WriteLine("Введите число для добавления в список");
            string? value = Console.ReadLine();
            if (string.IsNullOrEmpty(value))
            {
                break;
            }
            else if (strings.Contains(value))
            {
                Console.WriteLine("Такое число уже существует");
            }
            else
            {
                strings.Add(value);
                Console.WriteLine("Число успешно записано");
            }
        }
        Console.WriteLine("Список добавленных чисел: ");
        foreach (string s in strings)
        {
            Console.WriteLine(s);
        }
        #endregion
        Console.Clear();
        #region Work 4
        Console.WriteLine("Задание 4");

        Console.WriteLine("Введите ФИО");
        string? FIO = Console.ReadLine();
        Console.WriteLine("Введите название улицы");
        string? street = Console.ReadLine();
        Console.WriteLine("Введите номер дома");
        string? houseNumber = Console.ReadLine();
        Console.WriteLine("Введите номер квартиры");
        string? flatNumber = Console.ReadLine();
        Console.WriteLine("Введите номер мобильного телефона");
        string? mobilePhone = Console.ReadLine();
        Console.WriteLine("Введите номер домашнего телефона");
        string? flatPhone = Console.ReadLine();

        XElement Person = new XElement("Person");
        XElement Address = new XElement("Addres");
        XElement Street = new XElement("Street", street);
        XElement HouseNumber = new XElement("HouseNumber", houseNumber);
        XElement Phones = new XElement("Phones");
        XElement FlatNumber = new XElement("FlatNumber", flatNumber);
        XElement MobilePhone = new XElement("MobilePhone", mobilePhone);
        XElement FlatPhone = new XElement("FlatPhone", flatPhone);

        XAttribute namePerson = new XAttribute("name", FIO);

        Address.Add(Street, HouseNumber, FlatNumber);
        Phones.Add(MobilePhone, FlatPhone);
        Person.Add(namePerson, Address, Phones);

        Person.Save("Person.xml");

        #endregion
    }
}


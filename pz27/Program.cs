using System;

// создание структуры AEROFLOT
struct AEROFLOT
{
    public string NAZN; // название пункта назначения рейса
    public int NUMR; // номер рейса
    public string TIP; // тип самолета
};

class Program
{
    static void Main(string[] args)
    {
        // размерность массива AEROFLOT
        const int size = 7;
        // создание массива AEROFLOT
        AEROFLOT[] AIPORT = new AEROFLOT[size];

        Console.WriteLine("Введите данные для " + size + " рейсов:");

        // заполнение массива AIPORT данными с клавиатуры
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("\nРейс №" + (i + 1));
            Console.Write("Название пункта назначения: ");
            AIPORT[i].NAZN = Console.ReadLine();
            Console.Write("Номер рейса: ");
            AIPORT[i].NUMR = Convert.ToInt32(Console.ReadLine());
            Console.Write("Тип самолета: ");
            AIPORT[i].TIP = Console.ReadLine();
        }

        // сортировка массива AIPORT по названию пункта назначения

        Array.Sort(AIPORT, (a, b) => a.NAZN.CompareTo(b.NAZN));


        while (true)
        {
            Console.Write("\nВведите тип самолета для поиска: ");
            string searchTIP = Console.ReadLine();

            bool found = false;


            // вывод на экран пунктов назначения и номеров рейсов, обслуживаемых самолетом,
            // тип которого введен с клавиатуры
            for (int i = 0; i < size; i++)
            {
                if (AIPORT[i].TIP == searchTIP)
                {
                    Console.WriteLine("\nСамолет " + AIPORT[i].TIP + " Рейс №" + AIPORT[i].NUMR + " направлен в " + AIPORT[i].NAZN);
                    found = true;
                }
            }

            // если таких рейсов нет, выдать на дисплей соответствующее сообщение
            if (!found)
            {
                Console.WriteLine("\nРейсы на самолет типа " + searchTIP + " не найдены.");
                Console.Write("\nВыберете один из доступных самолётов: ");
                for (int i = 0;i < size;i++)
                {
                    Console.Write(AIPORT[i].TIP + " ");
                }  
            }

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;


namespace LINQ
{
    static class Messages
    {
        public static void Info()
        {
            Console.WriteLine("Выберите вариант меню:");
            Console.WriteLine("1 - Отобразить всю информацию о странах");
            Console.WriteLine("2 - Отобразить название стран");
            Console.WriteLine("3 - Отобразить название столиц");
            Console.WriteLine("4 - Отобразить название всех европейских стран");
            Console.WriteLine("5 - Отобразить название стран с площадью большей конкретного числа");
        }
        public static void Error()
        {
            Console.WriteLine("Ошибка! Введен неправильный пункт меню.");
        }
        public static void ShowResult(IEnumerable<object> items)
        {
            foreach (var item in items)
            {
                if (item is Country t)
                    Console.WriteLine($"Страна: {t.name}\nСтолица: {t.capital}\nНаселение: {t.population} человек\nПлощадь: {t.territory} км^2\nЧасть света: {t.partOfTheWorld}\n");
                else Console.WriteLine($"{item}");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{

    class Program
    {
        private static List<Country> countries;
        private static Dictionary<string, IEnumerable<object>> _menu;
        static void Main()
        {
            Country Russia = new Country("Russia", "Moscow", 146748590, 17098246, "Europe");
            Country Latvia = new Country("Latvia", "Riga", 1893700, 64589, "Europe");
            Country China = new Country("China", "Beijing", 1442965000, 9596961, "Asia");
            Country Kenya = new Country("Kenya", "Nairobi", 54985698, 580367, "Africa");
            Country USA = new Country("USA", "Washington", 332278200, 9826675, "North America");

            countries = new List<Country>() { Russia, Latvia, China, Kenya, USA };

            Messages.Info();

            var key = Console.ReadLine();

            _menu = new Dictionary<string, IEnumerable<object>>
            {
                {"1", null},
                {"2", countries.Select(item => item.name)},
                {"3", countries.Select(item => item.capital)},
                {"4", countries.Where(item=>item.partOfTheWorld=="Europe").Select(item=>item.name) },
                {"5", countries.Where(item => item.territory > 1400000 ).Select(item => item.name) }
            };
            Menu(key);

            
        }
        public static void Menu(string operationNumber)
        {
            if (!_menu.ContainsKey(operationNumber)) Messages.Error();
            else Show(_menu[operationNumber]);        
        }
                
        private static void Show(IEnumerable<object> items)
        {
            if (items==null) ShowAllInfo();

            else
            {
                foreach (var item in items)
                    Console.WriteLine($"{item}");
            }
             
        }
       
        private static void ShowAllInfo()
        {
             foreach (var country in countries) 
                Console.WriteLine($"Страна: {country.name}\nСтолица: {country.capital}\nНаселение: {country.population} человек\nПлощадь: {country.territory} км^2\nЧасть света: {country.partOfTheWorld}\n");
        }

    }

}

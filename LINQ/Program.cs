using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{

    class Program
    {
                
        static void Main()
        {
            Country Russia = new Country("Russia", "Moscow", 146748590, 17098246, "Europe");
            Country Latvia = new Country("Latvia", "Riga", 1893700, 64589, "Europe");
            Country China = new Country("China", "Beijing", 1442965000, 9596961, "Asia");
            Country Kenya = new Country("Kenya", "Nairobi", 54985698, 580367, "Africa");
            Country USA = new Country("USA", "Washington", 332278200, 9826675, "North America");

            List<Country> countries = new List<Country>() { Russia, Latvia, China, Kenya, USA };
         
            Messages.Info();

            var key = Console.ReadLine();

            Dictionary<string, IEnumerable<object>> _menu = new Dictionary<string, IEnumerable<object>>
            {
                {"1", countries.Select(item => item) },
                {"2", countries.Select(item => item.name)},
                {"3", countries.Select(item => item.capital)},
                {"4", countries.Where(item=>item.partOfTheWorld=="Europe").Select(item=>item.name)},
                {"5", countries.Where(item => item.territory > 1400000 ).Select(item => item.name)}
            };
            if (!_menu.ContainsKey(key)) Messages.Error();
            else Show(_menu[key]);           
                      
        }
                      
        private static void Show(IEnumerable<object> items)
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

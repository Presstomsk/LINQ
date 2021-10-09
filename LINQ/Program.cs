using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{

    class Program
    {
        delegate void Operation(IEnumerable<object> Obj);
        static void Main()
        {
            

            Country Russia = new Country("Russia", "Moscow", 146748590, 17098246, "Europe");
            Country Latvia = new Country("Latvia", "Riga", 1893700, 64589, "Europe");
            Country China = new Country("China", "Beijing", 1442965000, 9596961, "Asia");
            Country Kenya = new Country("Kenya", "Nairobi", 54985698, 580367, "Africa");
            Country USA = new Country("USA", "Washington", 332278200, 9826675, "North America");

            List<Country> countries = new List<Country>() { Russia, Latvia, China, Kenya, USA };

            List<IEnumerable<object>> selects = new List<IEnumerable<object>>()
            { 
                countries.Select(item => item),
                countries.Select(item => item.name),
                countries.Select(item => item.capital),
                countries.Where(item=>item.partOfTheWorld=="Europe").Select(item=>item.name),
                countries.Where(item => item.territory > 1400000 ).Select(item => item.name)
            };

            Operation Op;

            Messages.Info();

            var key = Console.ReadLine();

            Op = (items) => { Messages.ShowResult(items); };

           Dictionary<string, Operation> _menu = new Dictionary<string, Operation>
            {
                  {"1", Op},
                  {"2", Op},
                  {"3", Op},
                  {"4", Op},
                  {"5", Op}
            };
            if (!_menu.ContainsKey(key)) Messages.Error();
            else _menu[key](selects[Convert.ToInt32(key)-1]); 
            
                      
        }                 
              
    }

}

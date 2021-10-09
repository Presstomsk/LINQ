using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Country
    {
        public string name { get; init; }
        public string capital { get; private set; }
        public ulong population { get; private set; }
        public uint territory { get; private set; }
        public string partOfTheWorld  { get; private set; }

        public Country(string name, string capital, ulong population, uint territory, string partOfTheWorld)
        {
            this.name = name;
            this.capital = capital;
            this.population = population;
            this.territory = territory;
            this.partOfTheWorld = partOfTheWorld;
        }


    }
}

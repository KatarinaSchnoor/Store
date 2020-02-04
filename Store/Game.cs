using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Game
    {
        string name;
        string[] genres;
        float price;
        string description;
        List<DLC> dlcs;
        string systemRequirements;
        int metacritic;

        public Game(string name, string description, float price)
        {
            this.name = name;
            this.description = description;
            this.price = price;
        }
    }
}

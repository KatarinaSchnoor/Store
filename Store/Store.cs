using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Store
    {
        Showcase showcase;

        public Store()
        {
            showcase = new Showcase(5);

            Game g1 = new Game("Braid", "timeywimey puzzle game", 10f);

            // add games in the showcase
        }

        //buying
        //seeing what is for sale


    }
}

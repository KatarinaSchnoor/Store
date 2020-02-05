using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Showcase
    {
        Game[] games;
        bool bought = false;
        int size;
        int[] numberOfGames;

        public Showcase(int size)
        {
            games = new Game[size];
            this.size = size;

        }

        public void AddGame()
        {
            //For every slot we want to put in a game
            for (int i=0; i<size; i++)
            {
                Game g[i] = new Game(??);
            }

            //or?

            numberOfGames = new int [size];

            foreach (int i in numberOfGames)
            {
                Game g[i] = new Game (??); 
            }
            
            //Check if alreadyBought
            
        }

        public void RemoveGame()
        {
            bool bought = true;

            //Remove specific number game - find the number it has, then remove it, and add another
            AddGame();
        }

        public void Show()
        {
            bool alreadyBought = false;
            if (alreadyBought = true)
            {
                RemoveGame();
                alreadyBought = false;
                
            }
        }
    }
}

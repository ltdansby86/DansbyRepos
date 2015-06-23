using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Tournament
    {
        private int year;

        private int totalPlayera;

        private List<Game> gameList;

        private SortedList<Player, Game> finalRanking;

        internal SortedList<Player, Game> FinalRanking
        {
            get { return finalRanking; }
            set { finalRanking = value; }
        }

        internal List<Game> GameList
        {
            get { return gameList; }
            set { gameList = value; }
        }

        public int TotalPlayera
        {
            get { return totalPlayera; }
            set { totalPlayera = value; }
        }


        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public void addGames( Game newGame)
        {
            if(!gameList.Contains(newGame))
            {
                gameList.Add(newGame);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Game
    {
        private string title;
        
        private int numPlayers;

        private Player winner;

        private List<Player> allPlayers;
 
        private List<Player> topEight;
        
        internal List<Player> AllPlayers
        {
            get { return allPlayers; }
            set { allPlayers = value; }
        }
        
       
        
        public string Title
        {
            get { return title; }
            set { title = value; }
        }


        public int NumPlayers
        {
            get { return numPlayers; }
            set { numPlayers = value; }
        }     

        internal List<Player> TopEight
        {
            get { return topEight; }
            set { topEight = value; }
        }

        internal Player Winner
        {
            get { return winner; }
            set { winner = value; }
        }

        public void addPlayer(Player newPlayer)
        {
            if(!allPlayers.Contains(newPlayer))
            {
                allPlayers.Add(newPlayer);
            }
        }

        public void addTop8 (Player tePlayer)
        {
            if(!topEight.Contains(tePlayer))
            {
                topEight.Add(tePlayer);
            }
        }

    }
}

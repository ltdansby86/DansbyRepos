using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Admin
    {
        private string name;

        private Game game;

        internal Game Game
        {
            get { return game; }
            set { game = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void addPlayer(Player newPlayer)
        {

        }

        public void dqPlayer(Player dPlayer)
        {

        }

    }
}

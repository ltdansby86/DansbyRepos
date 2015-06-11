using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class Player
    {
        
        
        private string gamertag;

        private string firstname;


        private string lastname;


        private int wins;

        
        private int losses;

        
        private List<string> games;
        


        public int Wins
        {
            get { return wins; }
            set { wins = value; }
        }
        public int Losses
        {
            get { return losses; }
            set { losses = value; }
        }
        public List<string> Games
        {
            get { return games; }
            set { games = value; }
        }
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
      public string Gamertag
      {
        get { return gamertag; }
        set { gamertag = value; }
      }
      public string Firstname
      {
          get { return firstname; }
          set { firstname = value; }
      }

      public void createPlayer(Player newPlayer)
      {
      }
    public void addGame(string title)
      {
          if (!Games.Contains(title))
          {
              Games.Add(title);
          }
      }
    public void removeGame(string title)
    {
        if (Games.Contains(title))
        {
            Games.Remove(title);
        }
        else { }
    }
    public void removePlayer()
    {

    }

    public List<string> getallPlayer(SqlConnection conn)
    {
        List<string> playerList = new List<string>();
        string query = "select * from Player";
        try
        {
            conn.Open();
            SqlDataReader myDR = null;
            SqlCommand myCommand = new SqlCommand(query, conn);
            while (myDR.Read())
            {
                string gamerTag = myDR["GamerTag"].ToString();
                playerList.Add(gamertag);
            }
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        
            return playerList;
        

    }
    }
}
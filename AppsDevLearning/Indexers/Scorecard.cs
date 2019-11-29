using System.Collections.Generic;

namespace Indexers
{
    public class Scorecard
    {
        private  Dictionary<string, int> players = new Dictionary<string, int>();

        public void Add(string name, int score)
        {
            players.Add(name, score);
        }

        public int this[string name]
        {
            get
            {
                return players[name];
            }
        }
    }
}
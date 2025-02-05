using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaDungeon
{
    public class GameManager : Singleton<GameManager>
    {
        private Player player;

        public Player Player => player;

        public GameManager()
        {
            player = new Player("재원");
        }
    }
}

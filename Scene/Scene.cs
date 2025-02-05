using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaDungeon
{
    public class Scene
    {
        protected Player player;
        protected string sceneName;

        public Scene()
        {
            player = GameManager.Instance.Player;
        }

        public virtual void Start()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine($"현재 화면: {sceneName}");
            Console.WriteLine();
        }
    }
}

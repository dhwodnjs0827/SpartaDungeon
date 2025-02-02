using SpartaDungeon.Manager;

namespace SpartaDungeon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameManager gameManager = GameManager.Instance;
            gameManager.DrawScreen();
        }
    }
}

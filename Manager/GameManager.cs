using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaDungeon.Manager
{
    public class GameManager : Singleton<GameManager>
    {
        public void DrawScreen()
        {
            Console.SetCursorPosition(0, 0);
            Console.Write('┌');
            for (int i = 1; i <= 80; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write('─');
            }
            Console.SetCursorPosition(81, 0);
            Console.Write('┐');

            for (int i = 1; i <= 20; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write('│');
                Console.SetCursorPosition(81, i);
                Console.Write('│');
            }

            Console.SetCursorPosition(0, 21);
            Console.Write('└');
            for (int i = 1; i <= 80; i++)
            {
                Console.SetCursorPosition(i, 21);
                Console.Write('─');
            }
            Console.SetCursorPosition(81, 21);
            Console.Write('┘');
        }
    }
}

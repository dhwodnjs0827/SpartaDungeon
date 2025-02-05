using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaDungeon
{
    public class StartScene : Scene
    {
        public StartScene(string name)
        {
            SceneManager.Instance.AddScene(SceneType.Start, this);
            sceneName = name;
        }

        public override void Start()
        {
            base.Start();
            Console.Write("스파르타 마을에 오신 여러분을 환영합니다.\r\n이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.\r\n\r\n1. 상태 보기\r\n2. 인벤토리\r\n3. 상점\r\n\r\n0. 게임 종료\r\n\r\n원하시는 행동을 입력해주세요.\r\n>> ");
            int inputNum = SelectHelper.GetSelectedNum(3);

            HandleInput(inputNum);
        }

        private void HandleInput(int inputNum)
        {
            switch (inputNum)
            {
                case 0:
                    Console.Clear();
                    Console.Write("게임 종료");
                    break;
                case 1:
                    SceneManager.Instance.TransitionScene(SceneType.Status);
                    break;
                case 2:
                    SceneManager.Instance.TransitionScene(SceneType.Inventory);
                    break;
                case 3:
                    SceneManager.Instance.TransitionScene(SceneType.Shop);
                    break;
            }
        }
    }
}

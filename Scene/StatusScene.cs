using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaDungeon
{
    public class StatusScene : Scene
    {
        private Player player;

        public StatusScene(string name)
        {
            player = GameManager.Instance.Player;
            SceneManager.Instance.AddScene(SceneType.Status, this);
            sceneName = name;
        }

        public override void Start()
        {
            base.Start();
            string attackPower = player.ItemAttackPower > 0 ? $" (+{player.ItemAttackPower})" : "";
            string defensePower = player.ItemDefensePower > 0 ? $" (+{player.ItemDefensePower})" : "";
            Console.Write($"캐릭터의 정보가 표시됩니다.\r\n\r\nLv. {player.Level}\r\n{player.Name} ( {player.PlayerClass} )\r\n공격력: {player.AttackPower}{attackPower}\r\n방어력: {player.DefensePower}{defensePower}\r\n체력: {player.Health}\r\nGold: {player.Gold}G\r\n\r\n0. 나가기\r\n\r\n원하시는 행동을 입력해주세요.\r\n>> ");
            int inputNum = SelectHelper.GetSelectedNum(0);

            HandleInput(inputNum);
        }

        private void HandleInput(int inputNum)
        {
            switch (inputNum)
            {
                case 0:
                    SceneManager.Instance.TransitionScene(SceneType.Start);
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SpartaDungeon
{
    public class EquipmentScene : Scene
    {
        private Player player;
        private List<InventoryItem> inventoryItemList;

        public EquipmentScene(string name)
        {
            SceneManager.Instance.AddScene(SceneType.Equipment, this);
            sceneName = name;
            player = GameManager.Instance.Player;
            inventoryItemList = ItemManager.Instance.InvewntoryItemList;
        }

        public override void Start()
        {
            base.Start();
            Console.Write("보유 중인 아이템을 관리할 수 있습니다.\r\n\r\n[아이템 목록]\r\n\r\n");
            if (inventoryItemList.Count > 0)
            {
                for (int i = 0; i < inventoryItemList.Count; i++)
                {
                    string equipSymbol = inventoryItemList[i].IsEquipped ? "[E] " : "";
                    string stat = inventoryItemList[i].ItemType == eItemType.Weapon ? $"공격력 +{inventoryItemList[i].Stat.ToString()}" : $"방어력 +{inventoryItemList[i].Stat.ToString()}";
                    Console.Write($"- {i +1 } {equipSymbol}{inventoryItemList[i].Name} | {stat} | {inventoryItemList[i].Description}\r\n\r\n");
                }
            }
            Console.Write("0. 나가기\r\n\r\n원하시는 행동을 입력해주세요.\r\n>> ");
            int inputNum = SelectHelper.GetSelectedNum(inventoryItemList.Count + 1);

            HandleInput(inputNum);
        }

        private void HandleInput(int inputNum)
        {
            switch (inputNum)
            {
                case 0:
                    SceneManager.Instance.TransitionScene(SceneType.Inventory);
                    break;
                default:
                    inventoryItemList[inputNum - 1].ToggelEquipped();
                    player.AdjustItemStat(inventoryItemList[inputNum - 1]);
                    Console.Clear();
                    Start();
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaDungeon
{
    public class InventoryScene : Scene
    {
        private List<InventoryItem> inventoryItemList;

        public InventoryScene(string name)
        {
            SceneManager.Instance.AddScene(SceneType.Inventory, this);
            sceneName = name;
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
                    Console.Write($"- {equipSymbol}{inventoryItemList[i].Name} | {stat} | {inventoryItemList[i].Description}\r\n\r\n");
                }
            }
            Console.Write("1. 장착 관리\r\n0. 나가기\r\n\r\n원하시는 행동을 입력해주세요.\r\n>> ");
            int inputNum = SelectHelper.GetSelectedNum(1);

            HandleInput(inputNum);
        }

        private void HandleInput(int inputNum)
        {
            switch (inputNum)
            {
                case 0:
                    SceneManager.Instance.TransitionScene(SceneType.Start);
                    break;
                case 1:
                    SceneManager.Instance.TransitionScene(SceneType.Equipment);
                    break;
            }
        }
    }
}

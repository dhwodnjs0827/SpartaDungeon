using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaDungeon
{
    public class ShopScene : Scene
    {
        private List<ShopItem> shopItemList;

        public ShopScene(string name)
        {
            SceneManager.Instance.AddScene(SceneType.Shop, this);
            sceneName = name;
            shopItemList = ItemManager.Instance.ShopItemList;
        }

        public override void Start()
        {
            base.Start();
            Console.Write($"필요한 아이템을 얻을 수 있는 상점입니다.\r\n\r\n[보유 골드]\r\n {player.Gold}G\r\n\r\n[아이템 목록]\r\n");
            if (shopItemList.Count > 0)
            {
                for (int i = 0; i < shopItemList.Count; i++)
                {
                    string stat = shopItemList[i].ItemType == eItemType.Weapon ? $"공격력 +{shopItemList[i].Stat.ToString()}" : $"방어력 +{shopItemList[i].Stat.ToString()}";
                    string price = shopItemList[i].IsSold ? "구매완료" : shopItemList[i].Price.ToString() + "G";
                    Console.Write($"- {i + 1} {shopItemList[i].Name} | {stat} | {shopItemList[i].Description} | {price}\r\n\r\n");
                }
            }
            Console.Write("\r\n0. 나가기\r\n\r\n원하시는 행동을 입력해주세요.\r\n>> ");
            int inputNum = SelectHelper.GetSelectedNum(shopItemList.Count + 1);

            HandleInput(inputNum);
        }

        private void HandleInput(int inputNum)
        {
            switch (inputNum)
            {
                case 0:
                    SceneManager.Instance.TransitionScene(SceneType.Start);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine(player.BuyItem(shopItemList[inputNum - 1]));
                    Console.Write("Enter 키를 누르세요");
                    if (Console.ReadLine() != null)
                    {
                        Console.Clear();
                        Start();
                    }
                    break;
            }
        }
    }
}

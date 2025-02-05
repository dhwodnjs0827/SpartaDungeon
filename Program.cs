
namespace SpartaDungeon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InventoryItem noviceArmor = new InventoryItem(eItemType.Armor, "수련자", 5, "수련에 도움을 주는 갑옷입니다.", 1000);
            //InventoryItem ironArmor = new InventoryItem(eItemType.Armor, "무쇠갑옷", 9, "무쇠로 만들어져 튼튼한 갑옷입니다.", 2200);
            //InventoryItem spartaArmor = new InventoryItem(eItemType.Armor, "스파르타의 갑옷", 15, "스파르타의 전사들이 사용했다는 전설의 갑옷입니다.", 3500);
            //InventoryItem oldSword = new InventoryItem(eItemType.Weapon, "낡은 검", 2, "쉽게 볼 수 있는 낡은 검 입니다.", 600);
            //InventoryItem bronzeAx = new InventoryItem(eItemType.Weapon, "청동 도끼", 5, "어디선가 사용됐던거 같은 도끼입니다.", 1500);
            //InventoryItem spartaSpear = new InventoryItem(eItemType.Weapon, "스파르타의 창", 7, "스파르타의 전사들이 사용했다는 전설의 창입니다.", 2200);

            ShopItem noviceArmor = new ShopItem(eItemType.Armor, "수련자", 5, "수련에 도움을 주는 갑옷입니다.", 1000);
            ShopItem ironArmor = new ShopItem(eItemType.Armor, "무쇠갑옷", 9, "무쇠로 만들어져 튼튼한 갑옷입니다.", 2200);
            ShopItem spartaArmor = new ShopItem(eItemType.Armor, "스파르타의 갑옷", 15, "스파르타의 전사들이 사용했다는 전설의 갑옷입니다.", 3500);
            ShopItem oldSword = new ShopItem(eItemType.Weapon, "낡은 검", 2, "쉽게 볼 수 있는 낡은 검 입니다.", 600);
            ShopItem bronzeAx = new ShopItem(eItemType.Weapon, "청동 도끼", 5, "어디선가 사용됐던거 같은 도끼입니다.", 1500);
            ShopItem spartaSpear = new ShopItem(eItemType.Weapon, "스파르타의 창", 7, "스파르타의 전사들이 사용했다는 전설의 창입니다.", 2200);

            StartScene startScene = new StartScene("시작 화면");
            StatusScene statusScene = new StatusScene("스탯창");
            InventoryScene inventoryScene = new InventoryScene("인벤토리");
            EquipmentScene equipmentScene = new EquipmentScene("인벤토리 - 장착 관리");
            ShopScene shopScene = new ShopScene("상점");

            startScene.Start();
        }
    }
}

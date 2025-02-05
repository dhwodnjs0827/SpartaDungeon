using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaDungeon
{
    public enum PlayerClass
    {
        Warrior,
        Rogue
    }

    public class Player
    {
        private int level;
        private string name;
        private PlayerClass playerClass;
        private int attackPower;
        private int defensePower;
        private int health;
        private int gold;

        private int itemAttackPower;
        private int itemDefensePower;

        public int Level => level;
        public string Name => name;
        public PlayerClass PlayerClass => playerClass;
        public int AttackPower => attackPower + itemAttackPower;
        public int ItemAttackPower => itemAttackPower;
        public int DefensePower => defensePower + itemDefensePower;
        public int ItemDefensePower => itemDefensePower;
        public int Health => health;
        public int Gold
        {
            get => gold; set => gold = value;
        }

        public Player(string name)
        {
            level = 1;
            this.name = name;
            playerClass = PlayerClass.Warrior;
            attackPower = 10;
            defensePower = 5;
            health = 100;
            gold = 1500;
        }

        public void AdjustItemStat(InventoryItem item)
        {
            int figure;
            if (item.ItemType == eItemType.Weapon)
            {
                figure = item.IsEquipped ? item.Stat : -item.Stat;
                itemAttackPower += figure;
            }
            else
            {
                figure = item.IsEquipped ? item.Stat : -item.Stat;
                itemDefensePower += figure;
            }
        }

        public string BuyItem(ShopItem item)
        {
            if (item.IsSold)
            {
                return "이미 구매한 아이템입니다.";
            }
            else if (gold < item.Price)
            {
                return "Gold가 부족합니다.";
            }
            else
            {
                item.IsSold = true;
                gold -= item.Price;
                InventoryItem newItem = new InventoryItem(item.ItemType, item.Name, item.Stat, item.Description, item.Price);
                return "구매를 완료했습니다.";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaDungeon
{
    public class ShopItem : Item
    {
        private bool isSold;

        public bool IsSold
        {
            get => isSold;
            set => isSold = value;
        }

        public ShopItem(eItemType itemType, string name, int stat, string description, int price) : base(itemType, name, stat, description, price)
        {
            isSold = false;
            ItemManager.Instance.AddShopItem(this);
        }
    }
}

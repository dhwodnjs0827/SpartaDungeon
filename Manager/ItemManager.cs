using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaDungeon
{
    public class ItemManager : Singleton<ItemManager>
    {
        private List<InventoryItem> inventoryItemList;
        private List<ShopItem> shopItemList;

        public List<InventoryItem> InvewntoryItemList => inventoryItemList;
        public List<ShopItem> ShopItemList => shopItemList;

        public ItemManager()
        {
            inventoryItemList = new List<InventoryItem>();
            shopItemList = new List<ShopItem>();
        }

        public void AddInventoryItem(InventoryItem item)
        {
            if (!inventoryItemList.Contains(item))
            {
                inventoryItemList.Add(item);
            }
        }

        public void AddShopItem(ShopItem item)
        {
            if (!shopItemList.Contains(item))
            {
                shopItemList.Add(item);
            }
        }
    }
}

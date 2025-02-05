using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaDungeon
{
    public class InventoryItem : Item
    {
        private bool isEquipped;

        public bool IsEquipped => isEquipped;

        public InventoryItem(eItemType itemType, string name, int stat, string description, int price) : base(itemType, name, stat, description, price)
        {
            isEquipped = false;
            ItemManager.Instance.AddInventoryItem(this);
        }

        public void ToggelEquipped()
        {
            isEquipped = !isEquipped;
        }
    }
}

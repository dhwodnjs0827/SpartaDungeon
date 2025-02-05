using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaDungeon
{
    public enum eItemType
    {
        Weapon,
        Armor
    }

    public class Item
    {
        protected eItemType itemType;
        protected string name;
        protected int stat;
        protected string description;
        protected int price;

        public eItemType ItemType => itemType;
        public string Name => name;
        public int Stat => stat;
        public string Description => description;
        public int Price => price;

        public Item(eItemType itemType, string name, int stat, string description, int price)
        {
            this.itemType = itemType;
            this.name = name;
            this.stat = stat;
            this.description = description;
            this.price = price;
        }
    }
}

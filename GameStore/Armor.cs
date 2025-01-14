﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    public abstract class Armor : Items
    {
        protected int DefenseProvided;

        public Armor(int storePrice, int playerPrice, string itemSubClass, string raceType, string itemName, int defense) : base(storePrice, playerPrice, itemSubClass, raceType, itemName)
        {
            this.StorePrice = storePrice;
            this.PlayerSellPrice = playerPrice;
            this.itemSubClass = itemSubClass;
            this.RaceType = raceType;
            this.ItemName = itemName;
            this.DefenseProvided = defense;
        }

        public int GetDefense()
        {
            return DefenseProvided;
        }
    }
}

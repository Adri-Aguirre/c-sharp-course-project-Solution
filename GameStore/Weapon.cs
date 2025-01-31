﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    public abstract class Weapon : Items
    {
        protected string BaseDamage;
        public Weapon(int storePrice, int playerPrice, string itemSubClass, string raceType, string itemName, string baseDamage) : base(storePrice, playerPrice, itemSubClass, raceType, itemName)
        {
            this.StorePrice = storePrice;
            this.PlayerSellPrice = playerPrice;
            this.itemSubClass = itemSubClass;
            this.RaceType = raceType;
            this.ItemName = itemName;
            this.BaseDamage = baseDamage;
        }

        public string GetWeaponDamageRoll()
        {
            return this.BaseDamage;
        }
    }
}

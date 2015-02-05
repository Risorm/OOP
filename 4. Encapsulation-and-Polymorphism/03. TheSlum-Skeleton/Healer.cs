using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum.Interfaces;

namespace TheSlum
{
    class Healer:Character,IHeal
    {
        public int HealingPoints { get; set; }


        public Healer(string id, int x, int y, Team team, int range = 6, int healingPoints = 60, int healthPoints = 75, int defensePoints = 50)
            : base(id, x, y, healthPoints, defensePoints, team, range)
        {
            this.HealingPoints = healingPoints;
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            return targetsList.LastOrDefault(c => c.IsAlive && c.Team != this.Team);
        }

        public override void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
            ApplyItemEffects(item);
        }

        public override void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);
            RemoveItemEffects(item);
        }
        protected override void ApplyItemEffects(Item item)
        {
            base.ApplyItemEffects(item);
            this.HealingPoints += item.HealthEffect;
        }

        protected override void RemoveItemEffects(Item item)
        {
            base.RemoveItemEffects(item);
            this.HealingPoints -= item.HealthEffect;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(", Attack: {0}", this.HealingPoints);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum.Interfaces;

namespace TheSlum
{
    class Mage : Character, IAttack
    {
        public int AttackPoints { get; set; }

        public Mage(string id, int x, int y, Team team, int range = 2, int attackPoints = 300, int healthPoints = 150, int defensePoints = 50)
            : base(id, x, y, healthPoints, defensePoints, team, range)
        {
            this.AttackPoints = attackPoints;
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            throw new NotImplementedException();
        }

        public override void AddToInventory(Item item)
        {
            throw new NotImplementedException();
        }

        public override void RemoveFromInventory(Item item)
        {
            throw new NotImplementedException();
        }
    }
}

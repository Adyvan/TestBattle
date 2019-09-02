using System;
using System.Collections.Generic;
using System.Linq;
using TestBattle.Entities;
using TestBattle.Utility;

namespace TestBattle
{
    public class BattleManager
    {
        public BattleManager()
        {
        }

        public void Battle(Unit[] army1, Unit[] army2)
        {
            var localArmy1 = army1;
            var localArmy2 = army2;

            while (localArmy1.Length > 0 && localArmy2.Length > 0)
            {
                var armies = BattleTick(localArmy1, localArmy2);
                localArmy1 = armies.Item1;
                localArmy2 = armies.Item2;
            }
        }


        private Tuple<Unit[], Unit[]> BattleTick(Unit[] army1, Unit[] army2)
        {
            Attack(army1, army2);

            Attack(army2, army1);

            var result = new Tuple<Unit[], Unit[]>(
                army1.Where(x => !x.IsDead).ToArray(),
                army2.Where(x => !x.IsDead).ToArray());

            return result;
        }

        private void Attack(Unit[] defendsArmy, Unit[] atackArmy)
        {
            foreach(var attackItem in atackArmy)
            {
                var defendItem = defendsArmy.FirstOrDefault(x => !x.IsDead);

                if (defendItem == null) break; //has killed all army

                Attack(defendItem, attackItem);
            }
        }

        private void Attack(Unit defends, Unit attack)
        {
            var damages = GetCurrentDamage(attack);
            foreach(var damage in damages)
            {
                Attack(ref defends, damage);

                if (defends.IsDead) break;
            }
        }

        private void Attack(ref Unit defends, Power damage)
        {
            if (!IsDodge(defends.Dodge, damage.Type))
            {
                var resist = defends.Resistance.FirstOrDefault(x => x.Type == damage.Type);
                defends.Health -= damage.Value * (1 - resist.Value);
            }
        }

        private Power[] GetCurrentDamage(Unit attack)
        {
            var damage = attack.Damage;
            if (attack.IsFury)
            {
                damage = attack.ActiveDamage;
                attack.Fury = 0;
            }
            return damage;
        }

        private bool IsDodge(float dodge, PowerType power)
        {
            return power != PowerType.Net && RandomHelper.GetNext() <= dodge;
        }
    }
}

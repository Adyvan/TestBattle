using System;
using System.Collections.Generic;
using System.Linq;
using TestBattle.Entities;
using TestBattle.Utility;

namespace TestBattle
{
    public class BattleManager
    {
        readonly ILog _logger;

        public BattleManager(ILog logger)
        {
            _logger = logger;
        }

        public void Battle(Unit[] army1, Unit[] army2)
        {
            _logger.Log($"############## StartBattle");

            var localArmy1 = army1;
            var localArmy2 = army2;

            while (localArmy1.Length > 0 && localArmy2.Length > 0)
            {
                var armies = BattleTick(localArmy1, localArmy2);
                localArmy1 = armies.Item1;
                localArmy2 = armies.Item2;
            }

            if(localArmy1.Length > 0)
            {
                _logger.Log($"Frst Army Win!");
            }
            else if (localArmy2.Length > 0)
            {
                _logger.Log($"Second Army Win!");
            }
            else
            {
                _logger.Log($"Draw!");
            }

            _logger.Log($"############## EndBatle");
        }


        private Tuple<Unit[], Unit[]> BattleTick(Unit[] army1, Unit[] army2)
        {
            _logger.Log($"////////////// BatleTick");
            Attack(army1, army2);

            Attack(army2, army1);

            var result = new Tuple<Unit[], Unit[]>(
                army1.Where(x => !x.IsDead).ToArray(),
                army2.Where(x => !x.IsDead).ToArray());

            _logger.Log($"Deads:");
            foreach (var unit in army1.Concat(army2).Where(x=>x.IsDead))
            {
                _logger.Log($" {unit.Name}");
            }

            _logger.Log($"////////////// end BatleTick");
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
            _logger.Log($" {attack.Name} attack {defends.Name}");
            foreach (var damage in damages)
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

                _logger.Log($"  {defends.Name} has {damage.Type} damage {damage.Value * (1 - resist.Value)}");
            }
            else
            {
                _logger.Log($"  {defends.Name} has evade {damage.Type} damage");
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

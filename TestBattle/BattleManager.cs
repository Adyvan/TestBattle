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
            var army1Units = GetBattleUnits(army1);
            var army2Units = GetBattleUnits(army2);

            Attack(army1Units, army2Units);

            Attack(army2Units, army1Units);

            foreach (var unit in army1Units.Concat(army2Units).Where(x => !x.Unit.IsDead))
            {
                unit.Unit.Fury += GetAffitionalFury(unit.DamageDone, unit.DamageTaken, unit.Frag);
            }

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

        private BattleUnit[] GetBattleUnits(Unit[] units)
        {
            return units.Select(x => new BattleUnit(x)).ToArray();
        }

        private float GetAffitionalFury(float damageDone, float damageTaken, float frag)
        {
            return (damageTaken * 2 + damageDone * 0.5f + frag * 10) / 100f;
        }

        private void Attack(BattleUnit[] defendsArmy, BattleUnit[] atackArmy)
        {
            foreach(var attackItem in atackArmy)
            {
                var defendItem = defendsArmy.FirstOrDefault(x => !x.Unit.IsDead);

                if (defendItem == null) break; //has killed all army

                Attack(defendItem, attackItem);
            }
        }

        private void Attack(BattleUnit defends, BattleUnit attack)
        {
            var damages = GetCurrentDamage(attack.Unit);
            _logger.Log($" {attack.Unit.Name} attack {defends.Unit.Name}");
            foreach (var damage in damages)
            {
                var damageValue = Attack(ref defends.Unit, damage);

                defends.DamageTaken += damageValue;
                attack.DamageDone += damageValue;

                if (defends.Unit.IsDead)
                {
                    attack.Frag++;
                    break;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="defends"></param>
        /// <param name="damage"></param>
        /// <returns>Damage</returns>
        private float Attack(ref Unit defends, Power damage)
        {
            var damageValue = 0f;
            if (!IsDodge(defends.Dodge, damage.Type))
            {
                var resist = defends.Resistance.FirstOrDefault(x => x.Type == damage.Type);
                damageValue = damage.Value * (1 - resist.Value);

                defends.Health -= damageValue;

                _logger.Log($"  {defends.Name} has {damage.Type} damage {damageValue}");
            }
            else
            {
                _logger.Log($"  {defends.Name} has evade {damage.Type} damage");
            }

            return damageValue;
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

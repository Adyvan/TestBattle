using System;
namespace TestBattle.Entities
{
    public class BattleUnit
    {
        public Unit Unit;

        public float DamageDone { get; set; }

        public float DamageTaken { get; set; }

        public int Frag { get; set; }

        public BattleUnit(Unit unit)
        {
            Unit = unit;
        }
    }
}

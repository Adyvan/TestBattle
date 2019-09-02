using System;
namespace TestBattle.Entities
{
    public class Unit
    {
        public string Name { get; set; }

        public float Health { get; set; }

        public float Fury { get; set; }

        public Power[] Damage { get; set; }

        public Power[] ActiveDamage { get; set; }

        public Power[] Resistance { get; set; }

        public float Dodge { get; set; }


        public bool IsDead => Health <= 0;

        public bool IsFury => Fury >= 1;

        public Unit Copy()
        {
            return new Unit
            {
                Name = Name,
                Health = Health,
                Fury = Fury,
                Damage = Damage,
                ActiveDamage = ActiveDamage,
                Resistance = Resistance,
                Dodge = Dodge,
            };
        }
    }
}

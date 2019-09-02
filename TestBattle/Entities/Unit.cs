using System;
namespace TestBattle.Entities
{
    public class Unit
    {
        public float Health { get; set; }

        public float Fury { get; set; }

        public Power[] Damage { get; set; }

        public Power[] ActiveDamage { get; set; }

        public Power[] Resistance { get; set; }

        public float Dodge { get; set; }
    }
}

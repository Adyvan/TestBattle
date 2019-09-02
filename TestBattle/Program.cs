using System;
using TestBattle.Entities;

namespace TestBattle
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var army1 = new Unit[]
            {
                new Unit {
                    Name = "Воин 1",
                    Health = 100,
                    Fury = 0,
                    Damage = new Power[] { new Power {Type = PowerType.Physical, Value = 5 } },
                    ActiveDamage = new Power[] { new Power {Type = PowerType.Physical, Value = 10 } },
                    Resistance = new Power[] {
                        new Power {Type = PowerType.Physical, Value = 0.1f },
                        new Power {Type = PowerType.Magical, Value = 0.2f }
                    },
                },

                new Unit {
                    Name = "Воин 2",
                    Health = 100,
                    Fury = 0,
                    Damage = new Power[] { new Power {Type = PowerType.Physical, Value = 5 } },
                    ActiveDamage = new Power[] { new Power {Type = PowerType.Physical, Value = 10 } },
                    Resistance = new Power[] {
                        new Power {Type = PowerType.Physical, Value = 0.1f },
                        new Power {Type = PowerType.Magical, Value = 0.2f }
                    },
                },

                new Unit {
                    Name = "Воин 3",
                    Health = 100,
                    Fury = 0,
                    Damage = new Power[] { new Power {Type = PowerType.Physical, Value = 5 } },
                    ActiveDamage = new Power[] { new Power {Type = PowerType.Physical, Value = 10 } },
                    Resistance = new Power[] {
                        new Power {Type = PowerType.Physical, Value = 0.1f },
                        new Power {Type = PowerType.Magical, Value = 0.2f }
                    },
                },
                new Unit {
                    Name = "Воин 4",
                    Health = 100,
                    Fury = 0,
                    Damage = new Power[] { new Power {Type = PowerType.Physical, Value = 5 } },
                    ActiveDamage = new Power[] { new Power {Type = PowerType.Physical, Value = 10 } },
                    Resistance = new Power[] {
                        new Power {Type = PowerType.Physical, Value = 0.1f },
                        new Power {Type = PowerType.Magical, Value = 0.2f }
                    },
                },
                new Unit {
                    Name = "Воин 5",
                    Health = 100,
                    Fury = 0,
                    Damage = new Power[] { new Power {Type = PowerType.Physical, Value = 5 } },
                    ActiveDamage = new Power[] { new Power {Type = PowerType.Physical, Value = 10 } },
                    Resistance = new Power[] {
                        new Power {Type = PowerType.Physical, Value = 0.1f },
                        new Power {Type = PowerType.Magical, Value = 0.2f }
                    },
                },


            };

            var army2 = new Unit[]
            {
                new Unit {
                    Name = "Воин 11",
                    Health = 100,
                    Fury = 0,
                    Damage = new Power[] { new Power {Type = PowerType.Physical, Value = 5 } },
                    ActiveDamage = new Power[] { new Power {Type = PowerType.Physical, Value = 10 } },
                    Resistance = new Power[] {
                        new Power {Type = PowerType.Physical, Value = 0.1f },
                        new Power {Type = PowerType.Magical, Value = 0.2f }
                    },
                },

                new Unit {
                    Name = "Воин 12",
                    Health = 100,
                    Fury = 0,
                    Damage = new Power[] { new Power {Type = PowerType.Physical, Value = 5 } },
                    ActiveDamage = new Power[] { new Power {Type = PowerType.Physical, Value = 10 } },
                    Resistance = new Power[] {
                        new Power {Type = PowerType.Physical, Value = 0.1f },
                        new Power {Type = PowerType.Magical, Value = 0.2f }
                    },
                },

                new Unit {
                    Name = "Воин 13",
                    Health = 100,
                    Fury = 0,
                    Damage = new Power[] { new Power {Type = PowerType.Physical, Value = 5 } },
                    ActiveDamage = new Power[] { new Power {Type = PowerType.Physical, Value = 10 } },
                    Resistance = new Power[] {
                        new Power {Type = PowerType.Physical, Value = 0.1f },
                        new Power {Type = PowerType.Magical, Value = 0.2f }
                    },
                },
                new Unit {
                    Name = "Воин 14",
                    Health = 100,
                    Fury = 0,
                    Damage = new Power[] { new Power {Type = PowerType.Physical, Value = 5 } },
                    ActiveDamage = new Power[] { new Power {Type = PowerType.Physical, Value = 10 } },
                    Resistance = new Power[] {
                        new Power {Type = PowerType.Physical, Value = 0.1f },
                        new Power {Type = PowerType.Magical, Value = 0.2f }
                    },
                },
                new Unit {
                    Name = "Воин 15",
                    Health = 100,
                    Fury = 0,
                    Damage = new Power[] { new Power {Type = PowerType.Physical, Value = 5 } },
                    ActiveDamage = new Power[] { new Power {Type = PowerType.Physical, Value = 10 } },
                    Resistance = new Power[] {
                        new Power {Type = PowerType.Physical, Value = 0.1f },
                        new Power {Type = PowerType.Magical, Value = 0.2f }
                    },
                },
            };


            var bm = new BattleManager();

            bm.Battle(army1, army2);
        }
    }
}

using System;
using TestBattle.Entities;
using TestBattle.Utility;

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
                    Dodge = 0.09f,
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
                    Dodge = 0.09f,
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
                    Dodge = 0.09f,
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
                    Dodge = 0.09f,
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
                    Dodge = 0.09f,
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
                    Dodge = 0.09f,
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
                    Dodge = 0.09f,
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
                    Dodge = 0.09f,
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
                    Dodge = 0.09f,
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
                    Dodge = 0.09f,
                },
            };

            var cl = new ConsoleLogging();
            var bm = new BattleManager(cl);

            bm.Battle(army1, army2);

            Console.ReadLine();
        }
    }
}

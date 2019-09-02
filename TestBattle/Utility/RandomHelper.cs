using System;
namespace TestBattle.Utility
{
    public static class RandomHelper
    {
        private static Random random = new Random();

        public static float GetNext(float min = 0, float max = 1)
        {
            var delta = Math.Abs(max - min);
            return (float)random.NextDouble() * delta + min ;
        }
    }
}

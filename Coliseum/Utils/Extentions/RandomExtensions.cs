using System;

namespace Coliseum.Utils.Extentions
{
    public static class RandomExtensions
    {

        private static readonly Random _random = new Random();

        public static int GenerateRandomNumber(int min, int max)
        {
           return  _random.Next(min, max);
        }
    }
}

using OOP.Interfaces;
using System.Collections.Generic;

namespace OOP.Models
{
    public static class Extensions
    {
        public static IEnumerable<ICard> ShuffleCards(this IEnumerable<ICard> left, IEnumerable<ICard> right)
        {
            var leftEnumerator = left.GetEnumerator();
            var rightEnumerator = right.GetEnumerator();

            while (leftEnumerator.MoveNext() && rightEnumerator.MoveNext())
            {
                yield return leftEnumerator.Current;
                yield return rightEnumerator.Current;
            }
        }

    }
}

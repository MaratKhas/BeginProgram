using System.Collections.Generic;

namespace OOP.Models
{
    public static class Extensions
    {
        public static IEnumerable<Card> ShuffleCards(this IEnumerable<Card> left, IEnumerable<Card> right)
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

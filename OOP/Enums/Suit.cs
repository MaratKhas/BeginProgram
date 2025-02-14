namespace OOP.Enums
{
    public enum Suit
    {
        Bubi = 1,
        Сrosses,
        Peaks,
        Worms
    }

    public static class SuitExt
    {
        public static string ToString(this Suit s)
        {
            switch (s)
            {
                case Suit.Bubi:
                    {
                        return "Буби";
                    }
                case Suit.Сrosses:
                    {
                        return "Крести";
                    }
                case Suit.Peaks:
                    {
                        return "Пики";
                    }
                case Suit.Worms:
                    {
                        return "Червы";
                    }
                default: return "";
            }

        }
    }
}

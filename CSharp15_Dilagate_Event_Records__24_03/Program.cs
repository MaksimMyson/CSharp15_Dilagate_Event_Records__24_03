namespace CSharp15_Dilagate_Event_Records__24_03
{
    public class Fraction : IComparable<Fraction>
    {
        public int Numerator { get; }
        public int Denominator { get; }

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Denominator cannot be zero.");

            Numerator = numerator;
            Denominator = denominator;
        }

        public double ToDouble()
        {
            return (double)Numerator / Denominator;
        }

        public int CompareTo(Fraction other)
        {
            double thisValue = this.ToDouble();
            double otherValue = other.ToDouble();

            if (thisValue < otherValue)
                return -1;
            else if (thisValue > otherValue)
                return 1;
            else
                return 0;
        }
    }

    public static class FractionExtensions
    {
        public static Fraction Min(this Fraction[] fractions)
        {
            if (fractions.Length == 0)
                throw new ArgumentException("Array must contain at least one fraction.");

            Fraction minFraction = fractions[0];
            foreach (var fraction in fractions)
            {
                if (fraction.CompareTo(minFraction) < 0)
                    minFraction = fraction;
            }
            return minFraction;
        }

        public static Fraction Max(this Fraction[] fractions)
        {
            if (fractions.Length == 0)
                throw new ArgumentException("Array must contain at least one fraction.");

            Fraction maxFraction = fractions[0];
            foreach (var fraction in fractions)
            {
                if (fraction.CompareTo(maxFraction) > 0)
                    maxFraction = fraction;
            }
            return maxFraction;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Fraction[] fractions = {
            new Fraction(1, 2),
            new Fraction(3, 4),
            new Fraction(2, 5)
        };

            Fraction minFraction = fractions.Min();
            Fraction maxFraction = fractions.Max();

            Console.WriteLine($"Minimum fraction: {minFraction.Numerator}/{minFraction.Denominator}");
            Console.WriteLine($"Maximum fraction: {maxFraction.Numerator}/{maxFraction.Denominator}");
        }
    }
}

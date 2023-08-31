
namespace FractionC_;
//{
//    internal class Counter
//    {
//        private int min;
//        public int Min { get => this.min; set => this.min = value; }
//        public int Max { get; set; }
//        internal int currentData;

//        internal Counter(int min,int Max) {
//            this.min = min;
//            this.Max = Max;
//            currentData = min;
//        }

//        public void GetCurrent() => Console.WriteLine(currentData);

//        public void Increment()
//        {
//            if (currentData == Max - 1)
//            {
//                currentData = min;
//            }
//            else
//            {
//                currentData++;
//            }
//        }
//    }
//}


internal class Fraction
{
    private int numerator;
    public int Numerator { get => this.numerator; set => this.numerator = value; }

    private int denumerator;
    public int Denumerator { get=> this.denumerator; set {
            if (value > 0)
            {
                this.denumerator = value;
            }
            else
            {
                throw new Exception("Error");
            }
        } }

    internal Fraction(int numerator, int denumerator)
    {
        this.numerator = numerator;
        this.denumerator = denumerator;
    }

    
    public void Reduction()
    {
        int count = 1;
        if (numerator < Denumerator)
        {
            for (int i = 1; i <= numerator; i++)
            {
                if (numerator % i == 0 && Denumerator % i == 0)
                {
                    count=i;
                }
            }
        }
        else if (numerator > Denumerator) {
            for (int i = 1; i <= Denumerator; i++)
            {
                if (numerator % i == 0 && Denumerator % i == 0)
                {
                    count=i;
                }
            }
        }
        else
        {
            numerator = 1;
            Denumerator = 1;
        }
        numerator /= count;
        Denumerator /= count;
    }

    public void Addition(int numerator_2, int denominator_2)
    {
        numerator = numerator*denominator_2 + numerator_2 * Denumerator ;
        Denumerator *=denominator_2;
        Reduction();
    }

    public void Subtition(int numerator_2, int denominator_2)
    {
        numerator = numerator * denominator_2 - numerator_2 * Denumerator;
        Denumerator *= denominator_2;
        Reduction();
    }

    public void Multition(int numerator_2, int denominator_2)
    {
        numerator *= numerator_2;
        Denumerator *= denominator_2;
        Reduction();
    }

    public void Division(int numerator_2, int denominator_2)
    {
        numerator *= denominator_2;
        Denumerator *= numerator_2;
        Reduction();
    }

    public void Show()
    {
        Console.WriteLine($"Fraction : {numerator}/{Denumerator}");
    }

    public override string ToString()
    {
        return $"{numerator}/{Denumerator}";
    }
}
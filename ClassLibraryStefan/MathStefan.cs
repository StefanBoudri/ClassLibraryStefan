namespace ClassLibraryStefan;

public class MathStefan
{
    // Eulers number
    public const double E = 2.7182818284590452353602874713527;

    // returns the absolute value of a numeric expression
    public static double Abs(double x)
    {
        return x < 0 ? -x : x;
    }

    public static double Ln(double x)
    {
        return Logarithms.LnHandler(x);
    }
    public static double Pow(double a, double b)
    {
        return Power.PowerHandler(a, b);
    }
}


namespace ClassLibraryStefan;

public class MathStefan
{
    // Eulers number
    public const double E = 2.7182818284590452353602874713527;
    
    // Using formula e^x (e stand for Eulers number) together with taylor expansion series
    public static double Exp(double x)
    {
        int iterations = 10000000;

        double result = 1.0;
        for (int i = iterations; i > 0; i--)
        {
            result = 1 + x * result / i;
        }

        return result;
    }

    // returns the absolute value of a numeric expression
    public static double Abs(double x)
    {
        return x < 0 ? -x : x;
    }

    public static double Ln(double x)
    {
        return Logarithms.LnHandler(x);
    }

    public static double Log(double a, double b) 
    {
        return Logarithms.LogHandler(a, b);
    }

    public static double Pow(double a, double b)
    {
        return Power.PowerHandler(a, b);
    }

    public static double Sqrt(double x)
    {
        return Root.SqrtHandler(x);
    }
}


namespace ClassLibraryStefan;

internal class Logarithms : MathStefan
{
    // Natural logarithm using taylor expansion series
    // In the already build in Math class of C# you use Log(x) instead of Ln(x) as used here
    public static double LnHandler(double x)
    {
        if (x <= 0)
        {
            return double.NaN;
        }
        else if (x > 2)
        {
            return LnBigNumber(x);
        }
        else
        {
            return LnSmallNumber(x);
        }
    }

    // Using formula ln(x) = ln(a) + b * ln(2) where b is the number of iterations through the while loop and x = a
    private static double LnBigNumber(double x)
    {
        int b = 0;
        while (x > 1.5)
        {
            x /= 2;
            b++;
        }
        while (x < 0.75)
        {
            x *= 2;
            b--;
        }
        return LnSmallNumber(x) + b * LnSmallNumber(2);
    }

    // Using formula ln(x) = (x - 1) - (x - 1)^2 / 2 + (x - 1)^3 / 3 - (x - 1)^4 / 4 + ...
    private static double LnSmallNumber(double x)
    {
        int max = 10000;
        bool positive = true;
        double result = 0;
        for (int i = 1; i < max; i++)
        {
            if (positive)
            {
                result += Pow(x - 1, i) / i;
            }
            else
            {
                result -= Pow(x - 1, i) / i;
            }
            positive = !positive;
        }
        return result;
    }

    // Using formula Log(a, b) = ln(b)/ln(a)
    public static double LogHandler(double b, double a)
    {
       return Ln(b) / Ln(a);
    }
}

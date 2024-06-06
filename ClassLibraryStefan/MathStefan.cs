namespace ClassLibraryStefan;

public class MathStefan
{
    // Eulers number
    public const double E = 2.7182818284590452353602874713527;

    // Natural logarithm using taylor expansion series
    // In the already build in Math class of C# you use Log(x) instead of Ln(x) as used here
    public static double Ln(double x)
    {
        if (x > 2)
        {
            return LnBigNumber(x);
        }
        else
        {
            return LnSmallNumber(x);
        }
    }

    // Using formula ln(x)=ln(a)+b⋅ln(2) where b is the number of iterations through the while loop and x = a
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
        return Ln(x) + b * Ln(2);
    }

    // Using formula ln(x) = (x - 1) - (x - 1)^2 / 2 + (x - 1)^3 / 3 - (x - 1)^4 / 4 + ...
    private static double LnSmallNumber(double x)
    {
        int max = 5000;
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

    public static double Abs(double x)
    {
        return x < 0 ? -x : x;
    }

    public static double Pow(double baseNumber, double exponent)
    {
        if (exponent == 0)
        {
            return 1;
        }
        else if (exponent == 1)
        {
            return baseNumber;
        }
        else if (exponent > 0)
        {
            return PowerHandler(baseNumber, exponent);
        }
        else
        {
            return 1 / PowerHandler(baseNumber, -exponent);
        }
    }

    private static double PowerHandler(double baseNumber, double exponent)
    {
        double result = 1;
        for (int i = 0; i < exponent; i++)
        {
            result *= baseNumber;
        }
        return result;
    }
}



namespace ClassLibraryStefan;

internal class Power : MathStefan
{
    public static double PowerHandler(double baseNumber, double exponent)
    {
        if (exponent == 0)
        {
            return 1;
        }
        else if (exponent == 1)
        {
            return baseNumber;
        }
        else if (exponent % 1 != 0)
        {
            return PowerCalculatorDecimal(baseNumber, exponent);
        }
        else if (exponent > 0)
        {
            return PowerCalculator(baseNumber, exponent);
        }
        else
        {
            return 1 / PowerCalculator(baseNumber, -exponent);
        }
    }

    private static double PowerCalculatorDecimal(double baseNumber, double exponent)
    {
        return Exp(exponent * Ln(baseNumber));
    }

    private static double PowerCalculator(double baseNumber, double exponent)
    {
        double result = 1;
        for (int i = 0; i < exponent; i++)
        {
            result *= baseNumber;
        }
        return result;
    }
}
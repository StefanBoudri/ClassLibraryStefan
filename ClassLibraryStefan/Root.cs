using System.Runtime.CompilerServices;

namespace ClassLibraryStefan;

internal class Root : MathStefan
{
    // Using binary search to find the square root
    public static double SqrtHandler(double x)
    {
        double precision = 1e-20;
        double low = x < 1 ? x : 0;
        double high = x < 1 ? 1 : x;

        while (high - low > precision)
        {
            double mid = (low + high) / 2;
            double midSquared = mid * mid;
            if (Abs(midSquared - x) <= precision)
            {
                return mid;
            }
            else if (midSquared < x)
            {
                low = mid;
            }
            else
            {
                high = mid;
            }
        }
        return (low + high) / 2;
    }
}

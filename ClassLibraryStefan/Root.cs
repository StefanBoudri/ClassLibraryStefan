namespace ClassLibraryStefan;

internal class Root : MathStefan
{
    // Using binary search to find the square root
    public static double SqrtHandler(double x)
    {
        // Put this statement in due to flaws of the precision the binary search calculates
        if (x == 1)
        {
            return 1; 
        }

        // Precision highly impacts the loading time of the calculation
        // Looking for a fix to be precise but also calculate fast
        double precision = 1e-15;
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

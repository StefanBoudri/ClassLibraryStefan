namespace ClassLibraryStefan;

internal class SquareRoot : MathStefan
{
    public static double SqrtHandler(double x)
    {
        double sum = 0;
        double result = 0;
        while (x != sum)
        {
            result++;
            sum = result * result;
            if (sum > x) 
            {
                return Pow(x, 0.5);
            }
        }
        return result;
    }

}

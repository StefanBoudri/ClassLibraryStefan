namespace ClassLibraryStefan;

internal class Constrain
{
    public static double MinHandler(double a, double b)
    {
        return a < b ? a : b;
    }

    public static double MaxHandler(double a, double b) 
    {  
        return a > b ? a : b; 
    }
}

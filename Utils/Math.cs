using MyUtilities;

public class Matz
{

    public static void Math(string[] args)
    {

    }

    public static int Power(int num1, int powerOf)
    {
        int result = num1;
        int[] newArray = new int[powerOf];
        if (powerOf >= 0)
        {
            for (int power = 2; power <= powerOf; power++)
            {
                result *= num1;
            }

        }
        return result;
    }
    public static int Root(int num1, int rootOf)
    {
        int result = num1;
        int[] newArray = new int[rootOf];
        if (rootOf > 0)
        {
            for (int root = 2; root <= rootOf; root++)
            {
                result /= num1;
            }

        }
        return result;
    }
    public static int AbsoluteValue(int num1)
    {
        int result = num1;
        if (result! >= 0)
        {
            result *= -1;
            return result;
        }
        else
        {
            return result;
        }
    }
    public static int Max(int x, int y)
    {
        if (x > y)
        {
            return x;
        }
        else if (y > x)
        {
            return y;
        }
        else
        {
            return -1;
        }
    }
    public static int Min(int x, int y)
    {
        if (x < y)
        {
            return x;
        }
        else if (y < x)
        {
            return y;
        }
        else
        {
            return -1;
        }
    }
    public static int Add(int num1, int num2)
    {
        int result = num1 + num2;
        return result;
    }
    public static int Subtract(int num1, int num2)
    {
        int result = num1 - num2;
        return result;
    }
    public static int Multiply(int num1, int num2)
    {
        int result = num1 * num2;
        return result;
    }
    public static int Divide(int num1, int num2)
    {
        int result = num1 / num2;
        return result;
    }
    public static int AreaOfRectangle(int num1, int num2)
    {
        int result = num1 * num2;
        return result;
    }
    public static int FindCircleArea(int num1, int π)
    {
        int result = 2 * num1 * π;
        return result;
    }
    public static int FindRectPrismArea(int num1, int num2, int num3)
    {
        int result = num1 * num2 * num3;
        return result;
    }
    public static int Negate(int num1, int negate)
    {
        int result = num1 * negate;
        return result;
    }
}
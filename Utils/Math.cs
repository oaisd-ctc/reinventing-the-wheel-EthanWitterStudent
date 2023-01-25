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
    public static double Power(double num1, int powerOf)
    {
        double result = num1;
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
    public static float Power(float num1, int powerOf)
    {
        float result = num1;
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
    public static int AbsoluteValue(int num1)
    {
        int result = num1;
        if (result <= 0)
        {
            result *= -1;
            return result;
        }
        else
        {
            return result;
        }
    }
    public static double AbsoluteValue(double num1)
    {
        double result = num1;
        if (result <= 0)
        {
            result *= -1;
            return result;
        }
        else
        {
            return result;
        }
    }
    public static float AbsoluteValue(float num1)
    {
        float result = num1;
        if (result <= 0)
        {
            result *= -1;
            return result;
        }
        else
        {
            return result;
        }
    }

// Had to convert answers to int to get correct perfect squares
    public static int Root(int num1)
    {
        Console.WriteLine("!!ANSWERS MAY NOT BE 100% ACCURATE!!");
        if (num1 < 2)
            return num1;

        double y = num1;
        double z = (y + (num1 / y)) / 2;

        double num = AbsoluteValue(y - z);

        while ((y - z) >= 0.00001)
        {
            y = z;
            z = (y + (num1 / y)) / 2;
        }
        return (int)z;
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
            return x;
        }
    }
    public static double Max(double x, double y)
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
            return x;
        }
    }
    public static float Max(float x, float y)
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
            return x;
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
    public static double Min(double x, double y)
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
            return x;
        }
    }
    public static float Min(float x, float y)
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
            return x;
        }
    }

    public static int Add(int num1, int num2)
    {
        int result = num1 + num2;
        return result;
    }
    public static double Add(double num1, double num2)
    {
        double result = num1 + num2;
        return result;
    }
    public static float Add(float num1, float num2)
    {
        float result = num1 + num2;
        return result;
    }
    public static int Subtract(int num1, int num2)
    {
        int result = num1 - num2;
        return result;
    }
    public static double Subtract(double num1, double num2)
    {
        double result = num1 - num2;
        return result;
    }
    public static float Subtract(float num1, float num2)
    {
        float result = num1 - num2;
        return result;
    }
    public static int Multiply(int num1, int num2)
    {
        int result = num1 * num2;
        return result;
    }
    public static double Multiply(double num1, double num2)
    {
        double result = num1 * num2;
        return result;
    }
    public static float Multiply(float num1, float num2)
    {
        float result = num1 * num2;
        return result;
    }
    public static int Divide(int num1, int num2)
    {
        int result = num1 / num2;
        return result;
    }
    public static double Divide(double num1, double num2)
    {
        double result = num1 / num2;
        return result;
    }
    public static float Divide(float num1, float num2)
    {
        float result = num1 / num2;
        return result;
    }
    public static int AreaOfRectangle(int num1, int num2)
    {
        int result = num1 * num2;
        return result;
    }
    public static double AreaOfRectangle(double num1, double num2)
    {
        double result = num1 * num2;
        return result;
    }
    public static float AreaOfRectangle(float num1, float num2)
    {
        float result = num1 * num2;
        return result;
    }
    public static double FindCircleArea(double num1)
    {
        double π = 3.14159265359;
        double result = π * (num1 * num1);
        return result;
    }
    public static decimal FindCircleArea(decimal num1)
    {
        decimal π = 3.14159265359m;
        decimal result = π * (num1 * num1);
        return result;
    }
    public static int FindRectPrismArea(int num1, int num2, int num3)
    {
        int result = num1 * num2 * num3;
        return result;
    }
    public static double FindRectPrismArea(double num1, double num2, double num3)
    {
        double result = num1 * num2 * num3;
        return result;
    }
    public static float FindRectPrismArea(float num1, float num2, float num3)
    {
        float result = num1 * num2 * num3;
        return result;
    }
    public static int Negate(int num1)
    {
        int negate = -1;
        int result = num1 * negate;
        return result;
    }
    public static double Negate(double num1)
    {
        int negate = -1;
        double result = num1 * negate;
        return result;
    }
    public static float Negate(float num1)
    {
        int negate = -1;
        float result = num1 * negate;
        return result;
    }
}
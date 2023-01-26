namespace MyUtilities;

public class Matz
{

    public static void Math(string[] args)
    {

    }
    ///<summary>
    ///Multiplies a given integer to a given power
    ///</summary>
    ///<param name="f">The base number.</param>
    ///<param name="e">The exponenet.</param>
    ///<returns>
    ///f^e
    ///</returns>
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
    ///<summary>
    ///Multiplies a given double to a given power
    ///</summary>
    ///<param name="f">The base number.</param>
    ///<param name="e">The exponenet.</param>
    ///<returns>
    ///f^e
    ///</returns>

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
    ///<summary>
    ///Multiplies a given float to a given power
    ///</summary>
    ///<param name="f">The base number.</param>
    ///<param name="e">The exponenet.</param>
    ///<returns>
    ///f^e
    ///</returns>

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
    ///<summary>
    ///Calculates how far from 0 a given integer number is
    ///</summary>
    ///<param name="f">The number being calculated.</param>
    ///<returns>
    ///If positive = f; If negative = -f
    ///</returns>
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
    ///<summary>
    ///Calculates how far from 0 a given double number is
    ///</summary>
    ///<param name="f">The number being calculated.</param>
    ///<returns>
    ///If positive = f; If negative = -f
    ///</returns>

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
    ///<summary>
    ///Calculates how far from 0 a given float number is
    ///</summary>
    ///<param name="f">The number being calculated.</param>
    ///<returns>
    ///If positive = f; If negative = -f
    ///</returns>

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

    ///<summary>
    ///Finds square root of given number (rounded up because code doesn't know what the true square roots of perfect squares are)
    ///</summary>
    ///<param name="f">The number being rooted.</param>
    ///<returns>
    ///f^1/2
    ///</returns>
    public static int Root(int num1)
    {
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
    ///<summary>
    ///Find the heighest possible integer number between a range of given integer numbers
    ///</summary>
    ///<param name="f">Low number</param>
    ///<param name="e">High number</param>
    ///<returns>
    ///e
    ///</returns>
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
    ///<summary>
    ///Find the heighest possible integer number between a range of given double numbers
    ///</summary>
    ///<param name="f">Low number</param>
    ///<param name="e">High number</param>
    ///<returns>
    ///e
    ///</returns>

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
    ///<summary>
    ///Find the heighest possible integer number between a range of given float numbers
    ///</summary>
    ///<param name="f">Low number</param>
    ///<param name="e">High number</param>
    ///<returns>
    ///e
    ///</returns>
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
    ///<summary>
    ///Find the lowest possible integer number between a range of given integer numbers
    ///</summary>
    ///<param name="f">Low number</param>
    ///<param name="e">High number</param>
    ///<returns>
    ///f
    ///</returns>
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
    ///<summary>
    ///Find the lowest possible integer number between a range of given double numbers
    ///</summary>
    ///<param name="f">Low number</param>
    ///<param name="e">High number</param>
    ///<returns>
    ///f
    ///</returns>

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
    ///<summary>
    ///Find the lowest possible integer number between a range of given float numbers
    ///</summary>
    ///<param name="f">Low number</param>
    ///<param name="e">High number</param>
    ///<returns>
    ///f
    ///</returns>

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
    ///<summary>
    /// Adds two integer numbers (obviously)
    ///</summary>
    ///<param name="f">First number</param>
    ///<param name="e">Second number</param>
    ///<returns>
    ///f+e
    ///</returns>
    public static int Add(int num1, int num2)
    {
        int result = num1 + num2;
        return result;
    }
    ///<summary>
    /// Adds two double numbers (obviously)
    ///</summary>
    ///<param name="f">First number</param>
    ///<param name="e">Second number</param>
    ///<returns>
    ///f+e
    ///</returns>

    public static double Add(double num1, double num2)
    {
        double result = num1 + num2;
        return result;
    }
    ///<summary>
    /// Adds two float numbers (obviously)
    ///</summary>
    ///<param name="f">First number</param>
    ///<param name="e">Second number</param>
    ///<returns>
    ///f+e
    ///</returns>

    public static float Add(float num1, float num2)
    {
        float result = num1 + num2;
        return result;
    }
    ///<summary>
    /// Subtracts two integer numbers (obviously)
    ///</summary>
    ///<param name="f">First number</param>
    ///<param name="e">Second number</param>
    ///<returns>
    ///f-e
    ///</returns>
    public static int Subtract(int num1, int num2)
    {
        int result = num1 - num2;
        return result;
    }
    ///<summary>
    /// Subtracts two double numbers (obviously)
    ///</summary>
    ///<param name="f">First number</param>
    ///<param name="e">Second number</param>
    ///<returns>
    ///f-e
    ///</returns>

    public static double Subtract(double num1, double num2)
    {
        double result = num1 - num2;
        return result;
    }
    ///<summary>
    /// Subtracts two float numbers (obviously)
    ///</summary>
    ///<param name="f">First number</param>
    ///<param name="e">Second number</param>
    ///<returns>
    ///f-e
    ///</returns>

    public static float Subtract(float num1, float num2)
    {
        float result = num1 - num2;
        return result;
    }
    ///<summary>
    /// Multiplies two integer numbers (obviously)
    ///</summary>
    ///<param name="f">First number</param>
    ///<param name="e">Second number</param>
    ///<returns>
    ///f*e
    ///</returns>
    public static int Multiply(int num1, int num2)
    {
        int result = num1 * num2;
        return result;
    }
    ///<summary>
    /// Multiplies two double numbers (obviously)
    ///</summary>
    ///<param name="f">First number</param>
    ///<param name="e">Second number</param>
    ///<returns>
    ///f*e
    ///</returns>

    public static double Multiply(double num1, double num2)
    {
        double result = num1 * num2;
        return result;
    }
    ///<summary>
    /// Multiplies two float numbers (obviously)
    ///</summary>
    ///<param name="f">First number</param>
    ///<param name="e">Second number</param>
    ///<returns>
    ///f*e
    ///</returns>

    public static float Multiply(float num1, float num2)
    {
        float result = num1 * num2;
        return result;
    }
    ///<summary>
    /// Divides two integer numbers (obviously)
    ///</summary>
    ///<param name="f">First number</param>
    ///<param name="e">Second number</param>
    ///<returns>
    ///f/e
    ///</returns>
    public static int Divide(int num1, int num2)
    {
        int result = num1 / num2;
        return result;
    }
    ///<summary>
    /// Divides two double numbers (obviously)
    ///</summary>
    ///<param name="f">First number</param>
    ///<param name="e">Second number</param>
    ///<returns>
    ///f/e
    ///</returns>

    public static double Divide(double num1, double num2)
    {
        double result = num1 / num2;
        return result;
    }
    ///<summary>
    /// Divides two float numbers (obviously)
    ///</summary>
    ///<param name="f">First number</param>
    ///<param name="e">Second number</param>
    ///<returns>
    ///f/e
    ///</returns>

    public static float Divide(float num1, float num2)
    {
        float result = num1 / num2;
        return result;
    }
    ///<summary>
    ///Finds the area of a square/rectangle based by multiplying 2 integer numbers together
    ///</summary>
    ///<param name="f">First number</param>
    ///<param name="e">Second number</param>
    ///<returns>
    ///f*e
    ///</returns>
    public static int AreaOfRectangle(int num1, int num2)
    {
        int result = num1 * num2;
        return result;
    }
    ///<summary>
    ///Finds the area of a square/rectangle based by multiplying 2 double numbers together
    ///</summary>
    ///<param name="f">First number</param>
    ///<param name="e">Second number</param>
    ///<returns>
    ///f*e
    ///</returns>

    public static double AreaOfRectangle(double num1, double num2)
    {
        double result = num1 * num2;
        return result;
    }
    ///<summary>
    ///Finds the area of a square/rectangle based by multiplying 2 float numbers together
    ///</summary>
    ///<param name="f">First number</param>
    ///<param name="e">Second number</param>
    ///<returns>
    ///f*e
    ///</returns>

    public static float AreaOfRectangle(float num1, float num2)
    {
        float result = num1 * num2;
        return result;
    }
    ///<summary>
    ///Finds the area of a circle by multiplying a double number by itself and then by π
    ///</summary>
    ///<param name="f">Radius of circle</param>
    ///<returns>
    ///f*f*π
    ///</returns>
    public static double FindCircleArea(double num1)
    {
        double π = 3.14159265359;
        double result = π * (num1 * num1);
        return result;
    }
    ///<summary>
    ///Finds the area of a circle by multiplying a decimal number by itself and then by π
    ///</summary>
    ///<param name="f">Radius of circle</param>
    ///<returns>
    ///f*f*π
    ///</returns>

    public static decimal FindCircleArea(decimal num1)
    {
        decimal π = 3.14159265359m;
        decimal result = π * (num1 * num1);
        return result;
    }
    ///<summary>
    ///Finds the area of a rectangular prism or cube by multiplying 3 integer numbers together
    ///</summary>
    ///<param name="f">Length</param>
    ///<param name="e">Width</param>
    ///<param name="a">Height</param>
    ///<returns>
    ///f*e*a
    ///</returns>
    public static int FindRectPrismArea(int num1, int num2, int num3)
    {
        int result = num1 * num2 * num3;
        return result;
    }
    ///<summary>
    ///Finds the area of a rectangular prism or cube by multiplying 3 double numbers together
    ///</summary>
    ///<param name="f">Length</param>
    ///<param name="e">Width</param>
    ///<param name="a">Height</param>
    ///<returns>
    ///f*e*a
    ///</returns>

    public static double FindRectPrismArea(double num1, double num2, double num3)
    {
        double result = num1 * num2 * num3;
        return result;
    }
    ///<summary>
    ///Finds the area of a rectangular prism or cube by multiplying 3 float numbers together
    ///</summary>
    ///<param name="f">Length</param>
    ///<param name="e">Width</param>
    ///<param name="a">Height</param>
    ///<returns>
    ///f*e*a
    ///</returns>

    public static float FindRectPrismArea(float num1, float num2, float num3)
    {
        float result = num1 * num2 * num3;
        return result;
    }
    ///<summary>
    ///Finds the opposite of an integer number
    ///</summary>
    ///<param name="f">Negated number</param>
    ///<returns>
    ///-f
    ///</returns>
    public static int Negate(int num1)
    {
        int negate = -1;
        int result = num1 * negate;
        return result;
    }
    //<summary>
    //Finds the opposite of a double number
    //</summary>
    ///<param name="f">Negated number</param>
    ///<returns>
    ///-f
    ///</returns>

    public static double Negate(double num1)
    {
        int negate = -1;
        double result = num1 * negate;
        return result;
    }
    //<summary>
    //Finds the opposite of an float number
    //</summary>
    ///<param name="f">Negated number</param>
    ///<returns>
    ///-f
    ///</returns>

    public static float Negate(float num1)
    {
        int negate = -1;
        float result = num1 * negate;
        return result;
    }
}
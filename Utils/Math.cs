using System;

public class Matz
{

    public void Main(string[] args)
    {

    }

    public int Power(int num1, int powerOf)
    {
        int result = num1;
        int[] newArray = new int[powerOf];
        if (powerOf > 0)
        {
            foreach (int number in newArray)
            {
                result *= num1;
            }

        }
        return result;
    }
    public int SquareRoot(int num1, int rootOf)
    {
        int result = num1;
        int[] newArray = new int[rootOf];
        if (rootOf > 0)
        {
            foreach (int number in newArray)
            {
                result /= num1;
            }

        }
        return result;
    }
    public int AbsoluteValue(int num1)
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
    public int Add(int num1, int num2)
    {
        int result = num1 + num2;
        return result;
    }
    public int Subtract(int num1, int num2)
    {
        int result = num1 - num2;
        return result;
    }
    public int Multiply(int num1, int num2)
    {
        int result = num1 * num2;
        return result;
    }
    public int Divide(int num1, int num2)
    {
        int result = num1 / num2;
        return result;
    }
    public int AreaOfRectangle(int num1, int num2)
    {
        int result = num1 * num2;
        return result;
    }
    public int FindCircleArea(int num1, int π)
    {
        int result = 2 * num1 * π;
        return result;
    }
    public int FindRectPrismArea(int num1, int num2, int num3)
    {
        int result = num1 * num2 * num3;
        return result;
    }
    public int Negate(int num1, int negate)
    {
        int result = num1 * negate;
        return result;
    }
}
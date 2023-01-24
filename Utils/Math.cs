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
}
namespace MyUtilities;

public class ArrayUtils
{
    public static void Bowl(string[] args)
    {
        /*int[] Soup = new int[15];
        Random rand = new Random();
        for(int i = 0; i < Soup.Length; i++) {
            Soup[i] = rand.Next(1, 101);
        }*/
    }

//ints \/
        ///<summary>
        ///Finds the average of an array
        ///</summary>
        ///<param name="Soup"> The array going in </param>
        ///<returns>
        ///Average, the average of the array
        ///</returns>
    public static int Average (int[] Soup) {
        int Average = 0;
        for(int i = 0; i < Soup.Length; i++) {
            Average = Average + Soup[i];
        }
        Average = Average / Soup.Length;
        return Average;
    }

    
         ///<summary>
        ///Finds the largest number in an array
        ///</summary>
        ///<param name="Soup"> The Array going in </param>
        ///<returns>
        ///Maximum, the largest number in Soup
        ///</returns>
    public static int Max (int[] Soup) {
        int Max = 0;
        for(int i = 0; i < Soup.Length; i++) {
            if (Max < Soup[i]) {
                Max = Soup[i];
            }
        }
        return Max;
    }


     ///<summary>
        ///Finds the smallest number in an array
        ///</summary>
        ///<param name="Soup"> The Array going in </param>
        ///<returns>
        ///Minimum, the smallest number in Soup
        ///</returns>
    public static int Min (int[] Soup) {
        int Min = Soup[0];
        for(int i = 0; i < Soup.Length; i++) {
            if (Min > Soup[i]) {
                Min = Soup[i];
            }
        }
        return Min;
    }


     ///<summary>
        ///sorts the array's values from smallest number to largest
        ///</summary>
        ///<param name="Soup"> The Array going in </param>
        ///<returns>
        ///the array sorted from smallest to largest
        ///</returns>
    public static int[] SortAscending (int[] Soup) {
        int TempNum = 0;
        for (int i = 0; i <= Soup.Length - 1; i++) {
            for (int iTheSecond = i + 1; iTheSecond < Soup.Length; iTheSecond++) {
                if (Soup[i] > Soup[iTheSecond]) {
                    TempNum = Soup[i];
                    Soup[i] = Soup[iTheSecond];
                    Soup[iTheSecond] = TempNum;
                }
            }
        }
        return Soup;
    }


     ///<summary>
        ///sorts the array's values from largest number to smallest
        ///</summary>
        ///<param name="Soup"> The Array going in </param>
        ///<returns>
        ///the array sorted from largest to smallest
        ///</returns>
    public static int[] SortDescending (int[] Soup) {
        int TempNum = 0;
        for (int i = 0; i <= Soup.Length - 1; i++) {
            for (int iTheSecond = i + 1; iTheSecond < Soup.Length; iTheSecond++) {
                if (Soup[i] < Soup[iTheSecond]) {
                    TempNum = Soup[i];
                    Soup[i] = Soup[iTheSecond];
                    Soup[iTheSecond] = TempNum;
                }
            }
        }
        return Soup;

    }


    ///<summary>
    ///finds the sum of all the values in the array
    ///</summary>
    ///<param name="Soup"> The Array going in </param>
    ///<returns>
    ///the sum of the array
    ///</returns>
    public static int Sum (int[] Soup) {
        int Sum = 0;
        for(int i = 0; i < Soup.Length; i++) {
            Sum = Sum + Soup[i];
        }
        return Sum;
    }


    ///<summary>
    ///finds the product of all the values in the array
    ///</summary>
    ///<param name="Soup"> The Array going in </param>
    ///<returns>
    ///the product of the array
    ///</returns>
    public static int Product (int[] Soup) {
        int Product = 1;
        for(int i = 0; i < Soup.Length; i++) {
            Product = Product * Soup[i];
        }
        return Product;
    }


    ///<summary>
    ///takes an array and reverses the order of it's values
    ///</summary>
    ///<param name="Soup"> The Array going in </param>
    ///<returns>
    ///the array in reverse order
    ///</returns>
    public static int[] Reverse (int[] Soup) {
        int[] NewSoup = new int[Soup.Length];
        int iTheSecond = 0;
        for(int i = Soup.Length - 1; i >= 0; i--) {
            NewSoup[iTheSecond] = Soup[i];
            iTheSecond++;
        }
        return NewSoup;
    }

    
    ///<summary>
    ///Finds the Median value of an array
    ///</summary>
    ///<param name="Soup"> The Array going in </param>
    ///<returns>
    ///the median of the array
    ///</returns>
    public static int Median (int[] Soup) {
        int[] NewSoup = SortAscending(Soup);
        int i = NewSoup.Length / 2;
        int Median = NewSoup[i];
        return Median;
    }
    ///<summary>
    ///Finds the Range value of an array
    ///</summary>
    ///<param name="Soup"> The Array going in </param>
    ///<returns>
    ///the range of the array
    ///</returns>

    public static int Range (int[] Soup) {
        int MaxOfSoup = Max(Soup);
        int MinOfSoup = Min(Soup);
        int Range = MaxOfSoup - MinOfSoup;
        return Range;
    }
    ///<summary>
    ///Finds the Mode value of an array
    ///</summary>
    ///<param name="Soup"> The Array going in </param>
    ///<returns>
    ///the mode of the array
    ///</returns>

    public static int[] Mode (int[] Soup) {
        int CountOne = 0;
        int CountTwo = 0;
        int ArrayCount = 0;
        int AlreadyAMode = 0;
        int[] NewSoup = new int[Soup.Length];
        for (int i = 0; i <= Soup.Length - 1; i++) {
            for (int iTheSecond = 0; iTheSecond <= Soup.Length - 1; iTheSecond++) {
                if (Soup[i] == Soup[iTheSecond]) {
                    CountOne++;
                }
            }
            if (CountOne == CountTwo) {
                for (int itheFourth = ArrayCount - 1; itheFourth >= 0; itheFourth--) {
                    if (Soup[i] == NewSoup[itheFourth]) {
                        AlreadyAMode++;
                    }
                }
                if (AlreadyAMode <= 0) {
                    NewSoup[ArrayCount] = Soup[i];
                    ArrayCount++;
                }
                AlreadyAMode = 0;
            } else if (CountOne > CountTwo) {
                while (ArrayCount >= 0) {
                    NewSoup[ArrayCount] = 0;
                    ArrayCount--;
                }
                ArrayCount = 0;
                NewSoup[ArrayCount] = Soup[i];
                ArrayCount++;
                CountTwo = CountOne;
            }
            CountOne = 0;
        }
        int[] NewerSoup = new int[ArrayCount];
        for (int itheThird = 0; itheThird <= NewerSoup.Length - 1; itheThird++) {
            NewerSoup[itheThird] = NewSoup[itheThird];
        }
        return NewerSoup;
    }

    ///<summary>
    ///Finds the Average value of an array
    ///</summary>
    ///<param name="Soup"> The Array going in </param>
    ///<returns>
    ///Average, the average of the array
    ///</returns>
    public static double Average (double[] Soup) {
        double Average = 0;
        for(int i = 0; i < Soup.Length; i++) {
            Average = Average + Soup[i];
        }
        Average = Average / Soup.Length;
        return Average;
    }
         ///<summary>
        ///Finds the largest number in an array
        ///</summary>
        ///<param name="Soup"> The Array going in </param>
        ///<returns>
        ///Maximum, the largest number in Soup
        ///</returns>

    public static double Max (double[] Soup) {
        double Max = 0;
        for(int i = 0; i < Soup.Length; i++) {
            if (Max < Soup[i]) {
                Max = Soup[i];
            }
        }
        return Max;
    }
     ///<summary>
        ///Finds the smallest number in an array
        ///</summary>
        ///<param name="Soup"> The Array going in </param>
        ///<returns>
        ///Minimum, the smallest number in Soup
        ///</returns>

    public static double Min (double[] Soup) {
        double Min = Soup[0];;
        for(int i = 0; i < Soup.Length; i++) {
            if (Min > Soup[i]) {
                Min = Soup[i];
            }
        }
        return Min;
    }
     ///<summary>
        ///sorts the array's values from smallest number to largest
        ///</summary>
        ///<param name="Soup"> The Array going in </param>
        ///<returns>
        ///the array sorted from smallest to largest
        ///</returns>

    public static double[] SortAscending (double[] Soup) {
        double TempNum = 0;
        for (int i = 0; i <= Soup.Length - 1; i++) {
            for (int iTheSecond = i + 1; iTheSecond < Soup.Length; iTheSecond++) {
                if (Soup[i] > Soup[iTheSecond]) {
                    TempNum = Soup[i];
                    Soup[i] = Soup[iTheSecond];
                    Soup[iTheSecond] = TempNum;
                }
            }
        }
        return Soup;
    }
     ///<summary>
        ///sorts the array's values from largest number to smallest
        ///</summary>
        ///<param name="Soup"> The Array going in </param>
        ///<returns>
        ///the array sorted from largest to smallest
        ///</returns>

    public static double[] SortDescending (double[] Soup) {
        double TempNum = 0;
        for (int i = 0; i <= Soup.Length - 1; i++) {
            for (int iTheSecond = i + 1; iTheSecond < Soup.Length; iTheSecond++) {
                if (Soup[i] < Soup[iTheSecond]) {
                    TempNum = Soup[i];
                    Soup[i] = Soup[iTheSecond];
                    Soup[iTheSecond] = TempNum;
                }
            }
        }
        return Soup;

    }
    ///<summary>
    ///finds the sum of all the values in the array
    ///</summary>
    ///<param name="Soup"> The Array going in </param>
    ///<returns>
    ///the sum of the array
    ///</returns>

    public static double Sum (double[] Soup) {
        double Sum = 0;
        for(int i = 0; i < Soup.Length; i++) {
            Sum = Sum + Soup[i];
        }
        return Sum;
    }
    ///<summary>
    ///finds the product of all the values in the array
    ///</summary>
    ///<param name="Soup"> The Array going in </param>
    ///<returns>
    ///the product of the array
    ///</returns>

    public static double Product (double[] Soup) {
        double Product = 1;
        for(int i = 0; i < Soup.Length; i++) {
            Product = Product * Soup[i];
        }
        return Product;
    }
    ///<summary>
    ///takes an array and reverses the order of it's values
    ///</summary>
    ///<param name="Soup"> The Array going in </param>
    ///<returns>
    ///the array in reverse order
    ///</returns>

    public static double[] Reverse (double[] Soup) {
        double[] NewSoup = new double[Soup.Length];
        int iTheSecond = 0;
        for(int i = Soup.Length - 1; i >= 0; i--) {
            NewSoup[iTheSecond] = Soup[i];
            iTheSecond++;
        }
        return NewSoup;
    }
    ///<summary>
    ///Finds the Median value of an array
    ///</summary>
    ///<param name="Soup"> The Array going in </param>
    ///<returns>
    ///the median of the array
    ///</returns>

    public static double Median (double[] Soup) {
        double[] NewSoup = SortAscending(Soup);
        int i = NewSoup.Length / 2;
        double Median = NewSoup[i];
        return Median;
    }
    ///<summary>
    ///Finds the Range value of an array
    ///</summary>
    ///<param name="Soup"> The Array going in </param>
    ///<returns>
    ///the range of the array
    ///</returns>

    public static double Range (double[] Soup) {
        double MaxOfSoup = Max(Soup);
        double MinOfSoup = Min(Soup);
        double Range = MaxOfSoup - MinOfSoup;
        return Range;
    }
    ///<summary>
    ///Finds the Mode value of an array
    ///</summary>
    ///<param name="Soup"> The Array going in </param>
    ///<returns>
    ///the mode of the array
    ///</returns>

    public static double[] Mode (double[] Soup) {
        int CountOne = 0;
        int CountTwo = 0;
        int ArrayCount = 0;
        int AlreadyAMode = 0;
        double[] NewSoup = new double[Soup.Length];
        for (int i = 0; i <= Soup.Length - 1; i++) {
            for (int iTheSecond = 0; iTheSecond <= Soup.Length - 1; iTheSecond++) {
                if (Soup[i] == Soup[iTheSecond]) {
                    CountOne++;
                }
            }
            if (CountOne == CountTwo) {
                for (int itheFourth = ArrayCount - 1; itheFourth >= 0; itheFourth--) {
                    if (Soup[i] == NewSoup[itheFourth]) {
                        AlreadyAMode++;
                    }
                }
                if (AlreadyAMode <= 0) {
                    NewSoup[ArrayCount] = Soup[i];
                    ArrayCount++;
                }
                AlreadyAMode = 0;
            } else if (CountOne > CountTwo) {
                while (ArrayCount >= 0) {
                    NewSoup[ArrayCount] = 0;
                    ArrayCount--;
                }
                ArrayCount = 0;
                NewSoup[ArrayCount] = Soup[i];
                ArrayCount++;
                CountTwo = CountOne;
            }
            CountOne = 0;
        }
        double[] NewerSoup = new double[ArrayCount];
        for (int itheThird = 0; itheThird <= NewerSoup.Length - 1; itheThird++) {
            NewerSoup[itheThird] = NewSoup[itheThird];
        }
        return NewerSoup;
    }
}
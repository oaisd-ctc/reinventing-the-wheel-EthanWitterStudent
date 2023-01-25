public class Program
{
    public static void Bowl(string[] args)
    {
        int[] Soup = new int[15];
        Random rand = new Random();
        for(int i = 0; i < Soup.Length; i++) {
            Soup[i] = rand.Next(1, 101);
        }
        Console.WriteLine("Randomly Generated Numbers:");
        for(int i = 0; i < Soup.Length; i++) {
            Console.Write(Soup[i] + " ");
        }
        Console.WriteLine("");
        /*
        int MaximumOfSoup = Max(Soup);
        Console.WriteLine(MaximumOfSoup);

        int[] TomatoSoup = SortAscending(Soup);
        Console.WriteLine("Sorted small to big:");
        for(int i = 0; i < TomatoSoup.Length; i++) {
            Console.Write(TomatoSoup[i] + " ");
        }
        Console.WriteLine("");

        int[] BrocolliCheddarSoup = SortDescending(Soup);
        Console.WriteLine("Sorted big to small:");
        for(int i = 0; i < BrocolliCheddarSoup.Length; i++) {
            Console.Write(BrocolliCheddarSoup[i] + " ");
        }
        Console.WriteLine("");*/

        /*int[] TomatoSoup = Reverse(Soup);
        Console.WriteLine("Reversed:");
        for(int i = 0; i < TomatoSoup.Length; i++) {
            Console.Write(TomatoSoup[i] + " ");
        }
        Console.WriteLine("");*/
        int MedianOfSoup = Median(Soup);
        Console.WriteLine(MedianOfSoup);
    }

    public static int Average (int[] Soup) {
        int Average = 0;
        for(int i = 0; i < Soup.Length; i++) {
            Average = Average + Soup[i];
        }
        Average = Average / Soup.Length;
        return Average;
    }

    public static int Max (int[] Soup) {
        int Max = 0;
        for(int i = 0; i < Soup.Length; i++) {
            if (Max < Soup[i]) {
                Max = Soup[i];
            }
        }
        return Max;
    }

    public static int Min (int[] Soup) {
        int Min = 0;
        for(int i = 0; i < Soup.Length; i++) {
            if (Min < Soup[i]) {
                Min = Soup[i];
            }
        }
        return Min;
    }

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

    public static int Sum (int[] Soup) {
        int Sum = 0;
        for(int i = 0; i < Soup.Length; i++) {
            Sum = Sum + Soup[i];
        }
        return Sum;
    }

    public static int Product (int[] Soup) {
        int Product = 1;
        for(int i = 0; i < Soup.Length; i++) {
            Product = Product * Soup[i];
        }
        return Product;
    }

    public static int[] Reverse (int[] Soup) {
        int[] NewSoup = new int[Soup.Length];
        int iTheSecond = 0;
        for(int i = Soup.Length - 1; i >= 0; i--) {
            NewSoup[iTheSecond] = Soup[i];
            iTheSecond++;
        }
        return NewSoup;
    }

    public static int Median (int[] Soup) {
        int[] NewSoup = SortAscending(Soup);
        int i = NewSoup.Length / 2;
        int Median = NewSoup[i];
        return Median;
    }

    public static int Range (int[] Soup) {
        int MaxOfSoup = Max(Soup);
        int MinOfSoup = Min(Soup);
        int Range = MaxOfSoup - MinOfSoup;
        return Range;
    }
}
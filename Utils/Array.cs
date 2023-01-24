public class Program
{
    public static void Main(string[] args)
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

        int MaximumOfSoup = Max(Soup);
        Console.WriteLine(MaximumOfSoup);
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
}
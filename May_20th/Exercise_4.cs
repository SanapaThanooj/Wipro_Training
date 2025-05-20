using System;

class Program
{
    static void Main()
    {
      
        Console.Write("Enter the first string: ");
        string str1 = Console.ReadLine();
        Console.Write("Enter the second string: ");
        string str2 = Console.ReadLine();

        
        var (length, lcs) = LCS(str1, str2);

        
        Console.WriteLine($"Length of LCS: {length}");
        Console.WriteLine($"LCS: {lcs}");
    }

    static (int, string) LCS(string str1, string str2)
    {
        int m = str1.Length;
        int n = str2.Length;

        
        int[,] dp = new int[m + 1, n + 1];

        
        for (int i = 1; i <= m; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if (str1[i - 1] == str2[j - 1])
                {
                    dp[i, j] = dp[i - 1, j - 1] + 1; 
                }
                else
                {
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]); 
                }
            }
        }

       
        int length = dp[m, n];

        
        string lcs = ReconstructLCS(dp, str1, str2, m, n);

        return (length, lcs);
    }

    static string ReconstructLCS(int[,] dp, string str1, string str2, int m, int n)
    {
        string lcs = "";
        while (m > 0 && n > 0)
        {
            if (str1[m - 1] == str2[n - 1])
            {
                lcs = str1[m - 1] + lcs; 
                m--;
                n--;
            }
            else if (dp[m - 1, n] > dp[m, n - 1])
            {
                m--; 
            }
            else
            {
                n--; 
            }
        }
        return lcs;
    }
}

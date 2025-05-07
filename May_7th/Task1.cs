Class program
{
    static void frequencyofelement(int[] arr)
    {
        Dictionary<int, int> freq = new Dictionary<int, int>();
         foreach (int num in arr)
        {
            if (freq.ContainsKey(num))
             freq[num]++;
            else freq[num] = 1;
        }
        foreach (var pair in freq)
        {
         Console.WriteLine($"{pair.Key} appears {pair.Value} time{(pair.Value > 1 ? "s" : "")}");
        }
    }
    static void Main()
    {   
        int[] arr = { 1, 2, 3, 4, 4, 4, 4 };
        frequencyofelement(arr);
    }
}
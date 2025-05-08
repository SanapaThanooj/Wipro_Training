class Program
{
    static void Main()
    {
        Dictionary<string, string> cities = new Dictionary<string, string>{
            {"Mumbai","Maharashtra"},
            {"Bnagalore","Karnataka"},
            {"Chennai","Tamilnadu"},
            {"Kolkata","west Bengal"},
            {"Hyderabad","Telangana"}

        };

        Console.WriteLine("Indian cities and their States");

        foreach (var city in cities)
        {
            Console.WriteLine(city.Key + " is in " + city.Value);
        }
        if (cities.ContainsKey("Hyderabad"))
        {
            Console.WriteLine("Hyderabad is present in the dictionary");
        }
        else
        {
            Console.WriteLine("Hyderabad is not present in the dictionary");
        }

    }
}
using Claculator;

internal class Program
{
    private static void Main(string[] args)
    {
        // Values -----------------------
        int a = 5;
        double b = 4;

        // Result -----------------------
        var result = MathUnit.Add(a, b);

        // Final write console the result ----------------
        Console.WriteLine($"This is result => {result}");
    }
}
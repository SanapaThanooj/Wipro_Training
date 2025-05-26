using System;

public abstract class CompressionStrategy
{
    public abstract void Compress(string inputPath, string outputPath);
}

public class ZipCompression : CompressionStrategy
{
    public override void Compress(string inputPath, string outputPath)
    {
        Console.WriteLine($"Compressing {inputPath} to {outputPath} using ZIP.");
    }
}

public class RarCompression : CompressionStrategy
{
    public override void Compress(string inputPath, string outputPath)
    {
        Console.WriteLine($"Compressing {inputPath} to {outputPath} using RAR.");
    }
}

public class Compressor
{
    private CompressionStrategy _strategy;

    public Compressor(CompressionStrategy strategy)
    {
        _strategy = strategy;
    }

    public void SetStrategy(CompressionStrategy strategy)
    {
        _strategy = strategy;
    }

    public void Compress(string input, string output)
    {
        _strategy.Compress(input, output);
    }
}

public class Program
{
    public static void Main()
    {
        Compressor compressor = new Compressor(new ZipCompression());
        compressor.Compress("data.txt", "data.zip");

        compressor.SetStrategy(new RarCompression());
        compressor.Compress("data.txt", "data.rar");
    }
}

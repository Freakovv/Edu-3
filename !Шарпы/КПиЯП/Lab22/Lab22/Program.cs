using Lab22;

class Program
{
    static async Task Main(string[] args) 
    {
        Console.WriteLine("\nМетод Task:");
        await TaskMethod.Start();
        Console.WriteLine("\nМетод Parallel:");
        ParallelMethod.Start();
    }
}
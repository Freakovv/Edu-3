class Program
{
    static void Main()
    {
        Order order = new Order(); 

        order.OrderStatusChanged += (sender, message) =>
        {
            Console.WriteLine($"Событие: {message}");
        };


        Console.ReadLine(); 
    }
}
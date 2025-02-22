using System;
using System.Threading.Tasks;

public enum OrderState
{
    Формируется,
    ВОбработке,
    Доставляется,
    Доставлен
}

public class Order
{
    public DateOnly AcceptedDate { get; private set; }
    public DateOnly TransferedDate { get; private set; }
    public OrderState State { get; private set; }

    public event EventHandler<string>? OrderStatusChanged;

    public Order()
    {
        AcceptedDate = DateOnly.FromDateTime(DateTime.Now);
        State = OrderState.Формируется;
    }

    public void CreateOrder()
    {
        OnOrderStatusChanged($"Заказ создан [{AcceptedDate}]. Статус: {State}");
        Console.WriteLine("Мы постараемся как можно быстрее передать его в доставку!");

        ProcessOrderAsync();
    }

    private async void ProcessOrderAsync()
    {
        await Task.Delay(7000);

        Random random = new Random();
        int days = random.Next(1, 3);
        string message = $"Спустя {days} " + (days == 1 ? "календарный день..." : "календарных дня...");

        Console.WriteLine(message);
        await Task.Delay(2000);

        TransferedDate = AcceptedDate.AddDays(days);
        State = OrderState.Доставляется;

        OnOrderStatusChanged($"Заказ передан в доставку [{TransferedDate}]. Новый статус: {State}");
    }

    protected virtual void OnOrderStatusChanged(string message)
    {
        OrderStatusChanged?.Invoke(this, message);
    }
}
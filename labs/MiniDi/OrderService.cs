namespace MiniDi;

public class OrderService
{
    private readonly IMessageSender _sender;
    
    public OrderService(IMessageSender sender)
    {
        _sender = sender;
    }

    public void CreateOrder(string product)
    {
        Console.WriteLine($"Order created: {product}");
        _sender.Send("Your order has been received");
        
    }
}
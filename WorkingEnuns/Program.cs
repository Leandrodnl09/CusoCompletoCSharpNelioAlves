using WorkingEnuns.Entities;
using WorkingEnuns.Entities.Enums;

Order order = new Order {
    Id = 1080,
    Moment = DateTime.Now,
    Status = OrderStatus.PendingPaymant
};

Console.WriteLine(order);

string txt = OrderStatus.PendingPaymant.ToString();
OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

Console.WriteLine(txt);
Console.WriteLine(os);

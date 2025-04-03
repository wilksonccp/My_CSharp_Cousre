using System.Text;
using System.Globalization;
namespace ExerciciodeFixacao.Entities;


public class Order
{
    public DateTime Moment { get; set; }
    public OrderStatus OrderStatus{ get; set; }
    public Coustumer Coustumer{ get; set; }
    public List<OrderItem> items { get; set; } = new List<OrderItem>();

    public Order()
    {
    }
    public Order(DateTime moment, OrderStatus orderStatus, Coustumer coustumer)
    {
        Moment = moment;
        OrderStatus = orderStatus;
        Coustumer = coustumer;
    }

    public void addItem(OrderItem item)
    {
        items.Add(item);
    }
    public void RemoveItem(OrderItem item)
    {
        items.Remove(item);
    }
    public double Total()
    {
        double sum = 0;
        foreach(OrderItem item in items)
        {
            sum += item.SubTotal();
        }
        return sum;
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
        sb.AppendLine("Order status: " + OrderStatus);
        sb.AppendLine("Coustumer: " + Coustumer);
        sb.AppendLine("Order Items:");
        foreach(OrderItem item in items)
        {
            sb.AppendLine(item.ToString());
        }
        sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
        return sb.ToString();
    }
}

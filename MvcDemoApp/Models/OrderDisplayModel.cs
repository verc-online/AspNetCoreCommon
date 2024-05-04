using DataLibrary.Models;

namespace MvcDemoApp.Models;

public class OrderDisplayModel
{
    public OrderModel Order { get; set; }
    public string ItemPurchased { get; set; }
}
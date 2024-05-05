using DataLibrary.Models;

namespace BlazorClientDemoApp.Models
{
    public class OrderResultModel
    {
        public OrderModel Order { get; set; }
        public string ItemPurchased { get; set; }
    }
}

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BlazorServerDemoApp.Models;

public class OrderUpdateModel
{
    public int Id { get; set; }
    
    [Required]
    [MaxLength(20, ErrorMessage = "You need to keep the name to a max of 20 chars")]
    [MinLength(3, ErrorMessage = "You need to enter at least 3 chars for an order name")]
    [DisplayName("Name for the Order")]
    public string OrderName { get; set; }
}
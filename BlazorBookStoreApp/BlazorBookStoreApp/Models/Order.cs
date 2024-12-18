using System.ComponentModel.DataAnnotations;

namespace BlazorBookStoreApp.Models
{
    public class Order
    {
        [Key] // Explicitly mark CustomerId as the primary key (optional, if the naming convention is followed)
        public int OrderId { get; set; }
        public string OrderDetails { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}

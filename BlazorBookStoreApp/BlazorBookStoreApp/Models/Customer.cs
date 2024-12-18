using System.ComponentModel.DataAnnotations;

namespace BlazorBookStoreApp.Models
{
    public class Customer
    {
        [Key] // Explicitly mark CustomerId as the primary key (optional, if the naming convention is followed)
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}

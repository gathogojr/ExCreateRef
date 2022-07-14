using System.Collections.Generic;

namespace ExCreateRef.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public List<Order> Orders { get; set; }
    }
}

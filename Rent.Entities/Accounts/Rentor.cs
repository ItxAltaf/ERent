using Rent.Entities.Orders;
using System.Collections.Generic;

namespace Rent.Entities.Accounts
{
    
    public class Rentor:User
    {
        public List<Order> Orders { get; set; }
    }
}

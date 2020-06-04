using Rent.Entities.Advertisements;
using Rent.Entities.Common;
using Rent.Entities.Accounts;
using System;

namespace Rent.Entities.Orders
{

    public class Order
    {
        public int Id { get; set; }

        public string OrderCode { get; set; }
        public int AdvertisementId { get; set; }
        public virtual Advertisement Advertisement { get; set; }
        public int BuyerId { get; set; }
        public virtual  Rentor Buyer { get; set; }
        public DateTime CreatedOn { get; set; }
        public OrderStatus Status { get; set; }
        public double TotalPrice { get; set; }
        public int ReviewId { get; set; }
        public virtual Review Review { get; set; }
    }
}

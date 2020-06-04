using Rent.Entities.Accounts;
using Rent.Entities.Common;
using Rent.Entities.Orders;
using System;
using System.Collections.Generic;

namespace Rent.Entities.Advertisements
{
    public class Advertisement
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public double Price { get; set; }
        public virtual List<Image> Images { get; set; }

        public int? BadgeId { get; set; }
        public virtual Badge Badge { get; set; }

        public int? CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public int? SellerId { get; set; }
        public virtual Rentee Seller { get; set; }

        public int? DetailId { get; set; }
        public virtual AdvertisementDetail Detail { get; set; }
    }
}

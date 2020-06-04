using Rent.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Entities.Advertisements
{
    public class AdvertisementDetail
    {
       
        public int Id { get; set; }
        public string Description { get; set; }
        public double Discount { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ExpiredOn { get; set; }
        public TimeSpan Duration { get; set; }
        public virtual List<Order> Orders { get; set; }
        public int Rank { get; set; }
        public virtual Advertisement Advertisement { get; set; }
    }
}

using Rent.Entities.Advertisements;
using Rent.Entities.Common;
using System.Collections.Generic;

namespace Rent.Entities.Accounts
{
   
    public class Rentee:User
    {

        public virtual List<Advertisement> Advertisements { get; set; }
        public virtual List<Review> Reviews { get; set; }
        public bool CanAffliated { get; set; }
    }
}

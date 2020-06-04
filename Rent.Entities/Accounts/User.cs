using Rent.Entities.Common;
using System;
using System.Collections.Generic;

namespace Rent.Entities.Accounts
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DOB { get; set; }
        public List<Address> Addresses { get; set; }
        public Profile Profile { get; set; }
        public Image ProfileImage { get; set; }
        public Image CoverImage { get; set; }
        public int Rank { get; set; }
        public Badge Badge { get; set; }
    }
}

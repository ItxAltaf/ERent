using System;

namespace Rent.Entities.Advertisements
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }
        public int SubCategoryId { get; set; }
        public virtual SubCategory SubCategory { get; set; }
    }
}
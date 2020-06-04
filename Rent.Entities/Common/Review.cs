using System;

namespace Rent.Entities.Common
{
    public class Review
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Summary { get; set; }
        public int Stars { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsVisible { get; set; }
    }
}
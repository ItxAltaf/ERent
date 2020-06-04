using Rent.Entities.Advertisements;

namespace Rent.Entities.Common
{
    public class Image
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public float Height { get; set; }
        public float Width { get; set; }
        public string Caption { get; set; }
        public string Description { get; set; }
        public int AdvertisementId { get; set; }
        public virtual Advertisement Advertisement { get; set; }
    }
}

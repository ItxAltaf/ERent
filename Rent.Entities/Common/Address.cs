namespace Rent.Entities.Common
{
    public class Address : Location
    {
        public int Id { get; set; }
        public int HouseNumber { get; set; }
        public string Street { get; set; }
        public City City { get; set; }
    }
}
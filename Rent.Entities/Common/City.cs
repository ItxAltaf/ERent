namespace Rent.Entities.Common
{
    public class City : Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Code { get; set; }
        public Country Country { get; set; }
    }
}
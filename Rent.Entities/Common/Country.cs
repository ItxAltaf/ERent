namespace Rent.Entities.Common
{
    public class Country : Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Code { get; set; }
    }
}
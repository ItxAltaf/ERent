namespace Rent.Entities.Common
{
    public class Badge
    {
        public int Id { get; set; }

        public string Code { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Image Icon { get; set; }
    }
}

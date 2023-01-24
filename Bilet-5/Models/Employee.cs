using bilet_5.Models.Base;

namespace bilet_5.Models
{
    public class Employee:BaseEntity
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public string SocialLink { get; set; }
        public int PositionId { get; set; }
        public Position Position { get; set; }
    }
}

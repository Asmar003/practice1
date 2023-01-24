using System.ComponentModel.DataAnnotations.Schema;

namespace bilet_5.ViewModels
{
    public class CreateEmployeeVM
    {
        public string Name { get; set; }
        [NotMapped]
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public string SocialLink { get; set; }
    }
}

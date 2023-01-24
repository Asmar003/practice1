using bilet_5.Models.Base;

namespace bilet_5.Models
{
    public class Position:BaseEntity
    {
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }
    }
}

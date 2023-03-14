namespace Entities.Concrete
{
    public class Contact : BaseEntity
    {
        public string Adress { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }
        public string MapLocation { get; set; }
    }
}

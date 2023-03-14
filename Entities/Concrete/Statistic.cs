namespace Entities.Concrete
{
    public class Statistic : BaseEntity
    {
        public int NumberOfMembers { get; set; }
        public int NumberOfPsychologists { get; set; }
        public int HappyCustomer { get; set; }
        public int Awards { get; set; } //ödüller
    }
}

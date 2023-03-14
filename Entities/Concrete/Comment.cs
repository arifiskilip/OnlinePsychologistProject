using System;

namespace Entities.Concrete
{
    public class Comment : BaseEntity
    {
        public int PsychologistDetailId { get; set; }
        public string AppUserId { get; set; }
        public string CommentDetail { get; set; }
        public DateTime CommentDate { get; set; }

        public Psychologist Psychologist { get; set; }
        public AppUser AppUser { get; set; }
    }
}

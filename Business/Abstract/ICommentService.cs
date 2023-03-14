using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICommentService
    {
        List<Comment> GetAll();
        Comment GetById(int id);
        void Add(Comment comment);
        void Delete(Comment comment);
        void Update(Comment comment);
    }
}

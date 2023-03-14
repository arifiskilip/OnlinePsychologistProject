using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CommentManager : ICommentService
    {
        private readonly ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void Add(Comment comment)
        {
            _commentDal.Add(comment);
        }

        public Comment GetById(int id)
        {
            return _commentDal.Get(x => x.Id == id);
        }

        public void Delete(Comment comment)
        {
            _commentDal.Delete(comment);
        }

        public List<Comment> GetAll()
        {
            return _commentDal.GetAll();
        }

        public void Update(Comment comment)
        {
            _commentDal.Update(comment);
        }
    }
}

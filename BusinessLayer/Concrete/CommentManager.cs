using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
   public class CommentManager:ICommentServices
    {
        ICommentDal _commentdal;

        public CommentManager(ICommentDal commentdal)
        {
            _commentdal = commentdal;
        }

        public List<Comment> GetList()
        {
          return  _commentdal.GetList();
        }

        public void Tadd(Comment t)
        {
            _commentdal.Insert(t);
        }

        public void Tadd(Destination t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Comment t)
        {
            _commentdal.Delete(t);
        }

        public void TDelete(Destination t)
        {
            throw new NotImplementedException();
        }

        public Comment TGetByID(int id)
        {
            return _commentdal.GetByID(id);
        }

        public List<Comment> TGetDestinationByID(int id)
        {
            return _commentdal.GetListByFilter(x => x.DestinationID == id);
        }

        public List<Comment> TGetListCommentWithDestination()
        {
            return _commentdal.GetListCommentWithDestination();
        }

        public List<Comment> TGetListCommentWithDestinationAndUser(int id)
        {
            return _commentdal.GetListCommentWithDestinationAndUser(id);
        }

        public void TUpdate(Comment t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Destination t)
        {
            throw new NotImplementedException();
        }

        List<Destination> IGenericServices<Destination>.GetList()
        {
            throw new NotImplementedException();
        }

        Destination IGenericServices<Destination>.TGetByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}

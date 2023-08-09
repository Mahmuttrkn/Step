using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFGuideDal : GenericRepository<Guide>, IGuideDal
    {
        public void ChangeToFalse(int id)
        {
            
        }

        public void ChangeToTrue(int id)
        {
            throw new NotImplementedException();
        }
    }
}

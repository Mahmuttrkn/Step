using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.UnitOfWork
{
    public class UnifOfWorkDal : IUnifOfWorkDal
    {
        private readonly Context context;

        public UnifOfWorkDal(Context context)
        {
            this.context = context;
        }

        public void save()
        {
            context.SaveChanges();
        }
    }
}

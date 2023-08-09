using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericAccountRepository<T> : IGenericAccountDal<T> where T : class
    {
        private readonly Context context;

        public GenericAccountRepository(Context context)
        {
            this.context = context;
        }

        public T GetById(int id)
        {
            return context.Set<T>().Find(id);
        }

        public void Insert(T t)
        {
            context.Add(t);
        }

        public void MultiUpdate(List<T> t)
        {
            context.UpdateRange(t);
        }

        public void Update(T t)
        {
            context.Update(t);
        }
    }
}

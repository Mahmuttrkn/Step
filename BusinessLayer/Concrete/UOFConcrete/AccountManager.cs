using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.UnitOfWork;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete.UOFConcrete
{
    public class AccountManager : IAccountServices
    {
        private readonly IAccountDal accountDal;
        private readonly IUnifOfWorkDal unifOfWorkDal;

        public AccountManager(IAccountDal accountDal, IUnifOfWorkDal unifOfWorkDal)
        {
            this.accountDal = accountDal;
            this.unifOfWorkDal = unifOfWorkDal;
        }

        public Account TGetById(int id)
        {
            return accountDal.GetById(id);
        }

        public void TInsert(Account t)
        {
            accountDal.Insert(t);
            unifOfWorkDal.save();
        }

        public void TMultiUpdate(List<Account> t)
        {
            accountDal.MultiUpdate(t);
            unifOfWorkDal.save();
        }

        public void TUpdate(Account t)
        {
            accountDal.Update(t);
            unifOfWorkDal.save();
        }
    }
}

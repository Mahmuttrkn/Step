﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UserManager : IUserServices
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<AppUser> GetList()
        {
            return _userDal.GetList();
        }

        public void Tadd(AppUser t)
        {
            _userDal.Insert(t);
        }

        public void TDelete(AppUser t)
        {
            _userDal.Delete(t);
        }

        public AppUser TGetByID(int id)
        {
            return _userDal.GetByID(id);
        }
        public void TUpdate(AppUser t)
        {
            _userDal.Update(t);
        }
    }
}

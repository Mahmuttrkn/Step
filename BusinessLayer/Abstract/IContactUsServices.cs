﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IContactUsServices : IGenericServices<ContactUs>
    {
        List<ContactUs> TGetListContactUsByTrue();
        List<ContactUs> TGetListContactUsByFalse();
        void TContactUsStatusChangeToFalse(int id);
    }
}

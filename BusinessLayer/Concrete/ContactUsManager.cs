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
    public class ContactUsManager : IContactUsServices
    {
        IContactUsDal contactUsDal;

        public ContactUsManager(IContactUsDal contactUsDal)
        {
            this.contactUsDal = contactUsDal;
        }

        public List<ContactUs> GetList()
        {
            return contactUsDal.GetList();
            
        }

        public void Tadd(ContactUs t)
        {
            contactUsDal.Insert(t);
        }

        public void TContactUsStatusChangeToFalse(int id)
        {
            throw new NotImplementedException();
        }

        public void TDelete(ContactUs t)
        {
            contactUsDal.Delete(t);
        }

        public ContactUs TGetByID(int id)
        {
            return contactUsDal.GetByID(id);
        }

        public List<ContactUs> TGetListContactUsByFalse()
        {
            return contactUsDal.GetListContactUsByFalse();
        }

        public List<ContactUs> TGetListContactUsByTrue()
        {
            return contactUsDal.GetListContactUsByTrue();
        }

        public void TUpdate(ContactUs t)
        {
            contactUsDal.Update(t);
        }
    }
}

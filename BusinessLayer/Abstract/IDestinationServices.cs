using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IDestinationServices : IGenericServices<Destination>
    {
        public Destination TGetDestinationWithGuide(int id);
    }
}

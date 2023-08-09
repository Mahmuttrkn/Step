using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IExcelServices
    {
        byte[] ExcelList<T>(List<T> t) where T : class;
    }
}

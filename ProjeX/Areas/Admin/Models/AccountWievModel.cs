using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeX.Areas.Admin.Models
{
    public class AccountWievModel
    {
        public int SenderID { get; set; }
        public int ReceiverID{ get; set; }
        public decimal Amount{ get; set; }
      
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer.DTOS.DestinationDTOs
{
   public class DestinationDTO
    {
        public String City { get; set; }
        public String DayNight { get; set; }
        public double Price { get; set; }
        public int Capacity { get; set; }
    }
}

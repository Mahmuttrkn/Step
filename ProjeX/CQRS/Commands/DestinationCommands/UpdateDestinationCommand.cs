using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeX.CQRS.Commands.DestinationCommands
{
    public class UpdateDestinationCommand
    {
        public string City { get; set; }
        public int DestinationID { get; set; }
        public string DayNight { get; set; }
        public double Price { get; set; }
        public int Capacity { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeX.CQRS.Commands.DestinationCommands
{
    public class RemoveDestination
    {
        public RemoveDestination(int id)
        {
            this.id = id;
        }

        public int id { get; set; }
    }
}

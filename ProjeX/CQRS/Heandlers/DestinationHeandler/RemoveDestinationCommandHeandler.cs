using DataAccessLayer.Concrete;
using ProjeX.CQRS.Commands.DestinationCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeX.CQRS.Heandlers
{
    public class RemoveDestinationCommandHeandler
    {
        private readonly Context context;

        public RemoveDestinationCommandHeandler(Context context)
        {
            this.context = context;
        }
        public void Handle(RemoveDestination destination)
        {
            var values = context.Destinations.Find(destination.id);
            context.Destinations.Remove(values);
            context.SaveChanges();
        }
    }
}

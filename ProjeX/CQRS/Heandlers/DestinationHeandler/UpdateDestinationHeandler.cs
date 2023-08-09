using DataAccessLayer.Concrete;
using ProjeX.CQRS.Commands.DestinationCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeX.CQRS.Heandlers.DestinationHeandler
{
    public class UpdateDestinationHeandler
    {
        private readonly Context context;

        public UpdateDestinationHeandler(Context context)
        {
            this.context = context;
        }
        public void Handle(UpdateDestinationCommand p)
        {
            var values = context.Destinations.Find(p.DestinationID);
            values.Capacity = p.Capacity;
            values.City = p.City;
            values.DayNight = p.DayNight;
            values.Price = p.Price;
            context.SaveChanges();
        }
    }
}

using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using ProjeX.CQRS.Commands.DestinationCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeX.CQRS.Heandlers.DestinationHeandler
{
    public class CreateDestinationHeandler
    {
        private readonly Context context;

        public CreateDestinationHeandler(Context context)
        {
            this.context = context;
        }
        public void Handle(CreateDestinationCommand p)
        {
            context.Destinations.Add(new Destination
            {
                City = p.City,
                Price = p.Price,
                DayNight = p.DayNight,
                Capacity = p.Capacity,
                Status = true
            });
            context.SaveChanges();
        }
    }
}

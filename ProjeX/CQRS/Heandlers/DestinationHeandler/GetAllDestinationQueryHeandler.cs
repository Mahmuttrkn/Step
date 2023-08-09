using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using ProjeX.CQRS.Results.DestinationResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeX.CQRS.Heandlers.DestinationHeandler
{
    public class GetAllDestinationQueryHeandler
    {
        private readonly Context context;

        public GetAllDestinationQueryHeandler(Context context)
        {
            this.context = context;
        }
        public List<GetAllDestinationQueryResult> Handle()
        {
            var values = context.Destinations.Select(x => new GetAllDestinationQueryResult
            {
                ID = x.DestinationID,
                Capacity = x.Capacity,
                City = x.City,
                Price = x.Price,
                DayNight=x.DayNight
            }).AsNoTracking().ToList();
            return values;
        }
    }
}

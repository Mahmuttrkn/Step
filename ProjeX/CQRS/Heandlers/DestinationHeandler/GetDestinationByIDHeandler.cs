using DataAccessLayer.Concrete;
using ProjeX.CQRS.Queries.DestinationQueries;
using ProjeX.CQRS.Results.DestinationResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeX.CQRS.Heandlers.DestinationHeandler
{
    public class GetDestinationByIDHeandler
    {
        private readonly Context context;

        public GetDestinationByIDHeandler(Context context)
        {
            this.context = context;
        }
        public GetDestinationByID Handle(GetDestinationByIDQuery query)
        {
            var values = context.Destinations.Find(query.ID);
            return new GetDestinationByID
            {
                DestinationID = values.DestinationID,
                City = values.City,
                DayNight = values.DayNight,
                Price=values.Price,
                Capacity=values.Capacity
                
               
            };
        }
    }
}

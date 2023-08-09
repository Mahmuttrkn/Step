using MediatR;
using ProjeX.CQRS.Results.GuideResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeX.CQRS.Queries.GuideQueries
{
    public class GetGuideByIDQuery:IRequest<GetGuideByIDResult>
    {
        public GetGuideByIDQuery(int ıD)
        {
            ID = ıD;
        }

        public int ID { get; set; }
    }
}

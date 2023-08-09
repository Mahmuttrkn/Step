using DataAccessLayer.Concrete;
using MediatR;
using ProjeX.CQRS.Queries.GuideQueries;
using ProjeX.CQRS.Results.GuideResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ProjeX.CQRS.Heandlers.GuideHeandler
{
    public class GetGuideByIDHeandler : IRequestHandler<GetGuideByIDQuery, GetGuideByIDResult>
    {
        private readonly Context context;

        public GetGuideByIDHeandler(Context context)
        {
            this.context = context;
        }

        public async Task<GetGuideByIDResult> Handle(GetGuideByIDQuery request, CancellationToken cancellationToken)
        {
            var values = await context.Guids.FindAsync(request.ID);
            return new GetGuideByIDResult
            {
                Description = values.Description,
                GuideID = values.GuideID,
                Name = values.Name
            };
        }
    }
}

using DataAccessLayer.Concrete;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ProjeX.CQRS.Queries.GuideQueries;
using ProjeX.CQRS.Results.GuideResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ProjeX.CQRS.Heandlers.GuideHeandler
{
    public class GetAllGuideHeandler:IRequestHandler<GetAllGuideQuery,List<GetAllQueryResults>>
    {
        private readonly Context context;

        public GetAllGuideHeandler(Context context)
        {
            this.context = context;
        }

        public async Task<List<GetAllQueryResults>> Handle(GetAllGuideQuery request, CancellationToken cancellationToken)
        {
            return await context.Guids.Select(x => new GetAllQueryResults
            {

                GuideID = x.GuideID,
                Description = x.Description,
                Image = x.Image,
                Name = x.Name

            }).AsNoTracking().ToListAsync();
            
        }
    }
}
